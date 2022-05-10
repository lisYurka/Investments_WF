using System;
using System.Globalization;
using Invest.Entities;

namespace Invest.Services
{
    internal class DateValidation
    {
        public static int CalculateDays(int value) => InvestData.DepositDateType switch
        {
            0 => value,
            1 => GetDaysBtwDates(value),
            _ => 0
        };

        private static int GetDaysBtwDates(int monthes)
        {
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            DateTime currentMonth = DateTime.Now;
            DateTime lastMonth = calendar.AddMonths(DateTime.Now, monthes);
            return (lastMonth - currentMonth).Days;
        }
    }
}
