using System;
using System.Windows.Forms;
using Invest.Services;
using Invest.Entities;

namespace Invest.InvestForms
{
    public partial class CalculationForm : Form
    {
        private string? deposit_type;
        private double depositSum;
        private int deposit_currency, deposit_date;

        private const string base_url = "https://benefit.by/depozit/vklad/";

        public CalculationForm()
        {
            InitializeComponent();
            deposit_type = InvestFormSettings.ChooseUrlDepositType(InvestData.DepositType);
            depositSum = InvestData.DepositCurValue;
            deposit_currency = InvestData.DepositCurrency;
            deposit_date = DateValidation.CalculateDays(InvestData.DepositDateValue);
        }

        private void CalculationForm_Load(object sender, EventArgs e)
        {
            int click_counter = 0;

            string? url = InvestFormSettings.ChooseUrlCurrency(deposit_currency, base_url);
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Url = new Uri(url);
            webBrowser.ScriptErrorsSuppressed = true;

            webBrowser.DocumentCompleted += (se, ev) =>
            {
                HtmlElement? startDeposit = InvestFormSettings.GetElementById(webBrowser, "field4");
                HtmlElement? days = InvestFormSettings.GetElementById(webBrowser, "field5");
                HtmlElement? depositType = InvestFormSettings.GetElementById(webBrowser, "field46");

                startDeposit?.SetAttribute("value", depositSum.ToString());
                days?.SetAttribute("value", deposit_date.ToString());
                depositType?.SetAttribute("value", deposit_type);
                HtmlElement? submitBtn = InvestFormSettings.GetSubmitBtn(webBrowser);
                submitBtn?.InvokeMember("click");

                if (click_counter == 1)
                {
                    InvestFormSettings.AddDataToGrid(webBrowser, dataGridView1, depositSum, noBanksLb);

                    dateValueLb.Text += $"\n{deposit_date}";
                    depositTypeLb.Text += $"\n{InvestFormSettings.ChooseDepositType(InvestData.DepositType)}";
                    depositCurrencyLb.Text += $"({InvestFormSettings.ChooseCurrency(deposit_currency)})";
                    depositValueLb.Text += $"\n{depositSum}";

                    webBrowser.Stop();
                }
                else
                    click_counter++;
            };
        }
    }
}
