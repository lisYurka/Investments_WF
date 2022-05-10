using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invest.Services
{
    internal class InvestFormSettings
    {
        private static string? BankInfo { get; set; } = null;
        public static string? ChooseUrlDepositType(int value) => value switch
        {
            0 => "156572",//отзывной
            1 => "156573",//безотзывной
            _ => null
        };
        public static string? ChooseUrlCurrency(int value, string url) => value switch
        {
            0 => url += "bel-rub/",
            1 => url += "dollary/",
            2 => url += "evro/",
            _ => null
        };
        public static string? ChooseCurrency(int value) => value switch
        {
            0 => "BYN",
            1 => "USD",
            2 => "EUR",
            _ => null
        };
        public static string? ChooseDepositType(int value) => value switch
        {
            0 => "Отзывной",
            1 => "Безотзывной",
            _ => null
        };

        public static HtmlElement GetElementById(WebBrowser wb, string id) => wb.Document.GetElementById(id);
        public static HtmlElementCollection GetElementsByTagName(WebBrowser wb, string tag) => wb.Document.GetElementsByTagName(tag);

        public static HtmlElement? GetSubmitBtn(WebBrowser wb)
        {
            HtmlElementCollection tags = GetElementsByTagName(wb, "button");
            foreach (HtmlElement el in tags)
            {
                if (el.InnerText == "Подобрать")
                    return el;
            }
            return null;
        }

        //сделать возвращаемый тип List, ибо при полученном значении оно сразу прерывается
        private static List<string[]?> GetInfoAboutBanks(WebBrowser wb)
        {
            List<string[]?> coll = new List<string[]?>();
            HtmlElementCollection? banks = GetElementsByTagName(wb, "div");
            foreach (HtmlElement el in banks)
            {
                if (el.GetAttribute("className") == "sf")
                {
                    BankInfo = el.InnerText;
                    coll.Add(BankInfo.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                }
            }
            return coll;
        }

        public static void AddDataToGrid(WebBrowser wb, DataGridView dgv, double startValue, Label lb)
        {
            List<string[]?> info = GetInfoAboutBanks(wb);
            if (info != null)
            {
                foreach (var item in info)
                {
                    lb.ForeColor = System.Drawing.Color.Green;
                    lb.Text = "Под ваши требования соответствуют следующие банки";
                    Double.TryParse(item[^1]?.Replace('.', ','), out double earnValue);
                    item[^1] = Math.Round(earnValue - startValue, 3).ToString();
                    dgv.Rows.Add(item);
                }
            }
            else
            {
                lb.ForeColor = System.Drawing.Color.IndianRed;
                lb.Text = "Под ваши требования нет подходящих банков!";
            }
        }
    }
}
