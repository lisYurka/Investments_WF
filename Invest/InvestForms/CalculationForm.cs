using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invest.Services;
using Invest.Entities;

namespace Invest.InvestForms
{
    public partial class CalculationForm : Form
    {

        private string? deposit_type = InvestFormParams.ChooseUrlDepositType(InvestData.DepositType);
        private double depositSum = InvestData.DepositCurValue;
        private int deposit_currency = InvestData.DepositCurrency;
        private int deposit_date = DateValidation.CalculateDays(InvestData.DepositDateValue);

        private const string base_url = "https://benefit.by/depozit/vklad/";

        public CalculationForm()
        {
            InitializeComponent();
        }

        private void CalculationForm_Load(object sender, EventArgs e)
        {
            string? url = InvestFormParams.ChooseUrlCurrency(deposit_currency, base_url);
            WebBrowser webBrowser = new WebBrowser();
            //webBrowser.Navigate(new Uri(url));
            webBrowser.Url = new Uri(url);
            webBrowser.ScriptErrorsSuppressed = true;

            int click_counter = 0;
            webBrowser.DocumentCompleted += (se, ev) =>
            {
                HtmlElement? startDeposit = InvestFormParams.GetElementById(webBrowser, "field4");
                HtmlElement? days = InvestFormParams.GetElementById(webBrowser, "field5");
                HtmlElement? depositType = InvestFormParams.GetElementById(webBrowser, "field46");

                startDeposit?.SetAttribute("value", depositSum.ToString());
                days?.SetAttribute("value", deposit_date.ToString());
                depositType?.SetAttribute("value", deposit_type);
                HtmlElement? submitBtn = InvestFormParams.GetSubmitBtn(webBrowser);
                submitBtn?.InvokeMember("click");

                //получить банки
                if (click_counter == 1)
                {
                    InvestFormParams.AddDataToGrid(webBrowser, dataGridView1, depositSum, noBanksLb);

                    dateValueLb.Text += $"\n{deposit_date}";
                    depositTypeLb.Text += $"\n{InvestFormParams.ChooseDepositType(InvestData.DepositType)}";
                    depositCurrencyLb.Text += $"({InvestFormParams.ChooseCurrency(deposit_currency)})";
                    depositValueLb.Text += $"\n{depositSum}";

                    webBrowser.Stop();
                }
                else
                    click_counter++;
            };
        }
    }
}
