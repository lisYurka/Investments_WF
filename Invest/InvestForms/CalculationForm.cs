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

namespace Invest.InvestForms
{
    public partial class CalculationForm : Form
    {
        private string? deposit_type = ChooseDepositType(InvestCalculation.DepositType);
        private double depositSum = InvestInputForm.DepositStartSum;
        private int deposit_currency = InvestCalculation.DepositCurrency;
        //private double deposit_percentage = InvestInputForm.DepositPercentage;
        private int deposit_date = InvestInputForm.DepositDays;

        private const string base_url = "https://benefit.by/depozit/vklad/";
        public CalculationForm()
        {
            InitializeComponent();
        }

        private static string? ChooseDepositType(int value) => value switch
        {
            0 => "156572",
            1 => "156573",
            _ => null
        };

        private string? ChooseCurrency(int value, string url) => value switch
        {
            0 => url+= "bel-rub/",
            1 => url+= "dollary/",
            2 => url+="evro/",
            _ => null
        };

        private HtmlElement GetElementById(WebBrowser wb, string id) => wb.Document.GetElementById(id);
        private HtmlElementCollection GetElementsByTagName(WebBrowser wb, string tag) => wb.Document.GetElementsByTagName(tag);

        private HtmlElement? GetSubmitBtn(WebBrowser wb)
        {
            HtmlElementCollection tags = GetElementsByTagName(wb, "button");
            foreach (HtmlElement el in tags)
            {
                if (el.InnerText == "Подобрать")
                    return el;
            }
            return null;
        }

        private void CalculationForm_Load(object sender, EventArgs e)
        {
            string? url = ChooseCurrency(deposit_currency, base_url);
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Width = this.Width;
            webBrowser.Height = this.Height;
            //webBrowser.Navigate(new Uri(url));
            webBrowser.Url = new Uri(url);
            webBrowser.ScrollBarsEnabled = true;
            webBrowser.Visible = false;
            webBrowser.ScriptErrorsSuppressed = true;
            this.Controls.Add(webBrowser);

            webBrowser.DocumentCompleted += (se, ev) =>
            {
                HtmlElement? startDeposit = GetElementById(webBrowser, "field4");
                HtmlElement? days = GetElementById(webBrowser, "field5");
                HtmlElement? depositType = GetElementById(webBrowser, "field46");

                startDeposit?.SetAttribute("value", depositSum.ToString());
                days?.SetAttribute("value", deposit_date.ToString());
                //156572 - отзывной
                //156573 - безотзывной
                depositType?.SetAttribute("value", deposit_type);

                HtmlElement? submitBtn = GetSubmitBtn(webBrowser);
                submitBtn?.InvokeMember("click");

                webBrowser.Visible = true;
                System.Diagnostics.Debug.WriteLine(webBrowser.Url);
            };
        }
    }
}
