using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Invest.Services;

namespace Invest.InvestInput
{
    public partial class InvestInputForm : Form
    {
        public int DepositType { get; set; }
        public int DepositCurrency { get; set; }
        public int DepositDate { get; set; }
        public InvestInputForm()
        {
            InitializeComponent();

            investTypeCB.SelectedIndex = 0;
            investCurrencyCB.SelectedIndex = 1;
            investDateCB.SelectedIndex = 1;

            investTypeCB.SelectedIndexChanged += investTypeCB_SelectedIndexChanged;
            investCurrencyCB.SelectedIndexChanged += investCurrencyCB_SelectedIndexChanged;
            investDateCB.SelectedIndexChanged += investDateCB_SelectedIndexChanged;
        }

        private void investTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvestCalculation.DepositType = investTypeCB.SelectedIndex;
        }

        private void investCurrencyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvestCalculation.DepositCurrency = investCurrencyCB.SelectedIndex;
        }

        private void investDateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvestCalculation.DepositDateType = investDateCB.SelectedIndex;
        }

        private void cancelInputBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to close ?", "Warning!", 
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dlg == DialogResult.OK)
                this.Close();
        }

        private void confirmInputBtn_Click(object sender, EventArgs e)
        {
            DataValidation.GetInputValue(investValueTB.Text, out double value_d, out int value_i);
            DataValidation.GetInputValue(investPercentTB.Text, out double perc_d, out int perc_i);
            DataValidation.GetInputValue(investDateTB.Text, out double date_d, out int date_i);

            //подумать, как сделать выбор типа значения в зависимости от полученных результатов
            if (value_d != 0 || value_i != 0 || perc_d != 0 ||
                perc_i != 0 || date_d != 0 || date_i != 0)
            {
                DialogResult dlg = MessageBox.Show("Do you want to confirm your input?","Confirm", 
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dlg == DialogResult.OK)
                {
                    double res = InvestCalculation.CalculateResult(value_d, perc_d, date_i);
                    MessageBox.Show(res.ToString());
                }
            }
            else MessageBox.Show("BAD INPUT!");
        }
    }
}
