using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invest.Entities
{
    internal class InvestData
    {
        public static int DepositType { get; set; }
        public static int DepositCurrency { get; set; }
        public static double DepositCurValue { get; set; } = 500.46;
        public static int DepositDateValue { get; set; } = 120;
        public static int DepositDateType { get; set; }
    }
}
