using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Invest.Services
{
    internal static class DataValidation
    {
        //паттерн для проверки на int или double
        private const string pattern = @"^\d+(?:\,\d+)?$";

        //проверка на пустоту и цифры(в нашем случае вводятся только числа: целые либо с запятой)
        private static bool CheckTBEmpty(string value, out string? result)
        {
            result = null;
            if (string.IsNullOrEmpty(value))
                return false;
            else
            {
                result = value.Replace('.', ',');
                if (!Regex.IsMatch(result, pattern))
                    return false;
                else
                    return true;
            }
        }

        //собсна, парсим наши данные из строки в числа
        public static void GetInputValue(string value, out double d)
        {
            d = 0;
            if (CheckTBEmpty(value, out string? result)) {
                Double.TryParse(result, out d);
            }
        }

        //только дни всегда целые
        public static void GetInputDays(string value, out int i)
        {
            i = 0;
            if (CheckTBEmpty(value, out string? result))
            {
                Int32.TryParse(result, out i);
            }
        }
    }
}
