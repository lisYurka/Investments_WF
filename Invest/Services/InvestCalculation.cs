using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Invest.Services
{
    internal class InvestCalculation
    {
        public static int DepositType { get; set; }
        public static int DepositCurrency { get; set; }
        public static int DepositDateType { get; set; }

        private int CalculateDays(int value) => DepositDateType switch
        {
            0 => value,
            1 => value * 12,
            2 => value * 365,
            _ => 0
        };

        private static int GetDaysBtwDates(Calendar calendar, int monthes)
        {
            int currentMonth = calendar.GetMonth(DateTime.Now);
            for(int i = currentMonth; i < monthes)
        }

        //рассчитываем нашу процентную ставку (формула простых процентов)
        //date - при использовании в формуле должно быть в днях
        //percentage - в процентах
        public static double CalculateResult(double start_sum, double percentage, int date)
        {
            //s - это начисленный профит
            Calendar calendar = new GregorianCalendar();
            int daysInYear = calendar.GetDaysInYear(calendar.GetYear(DateTime.Now));

            double s = (start_sum * percentage * date) / (daysInYear * 100.0);
            return s;
        }
    }
}
