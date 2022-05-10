using System;
using System.Windows.Forms;

using Invest.Services;
using Invest.Entities;

namespace Invest.InvestForms
{
    public partial class InvestInputForm : Form
    {
        public InvestInputForm()
        {
            InitializeComponent();

            investTypeCB.SelectedIndex = InvestData.DepositType;
            investCurrencyCB.SelectedIndex = InvestData.DepositCurrency;
            investDateCB.SelectedIndex = InvestData.DepositDateType;
            investValueTB.Text = InvestData.DepositCurValue.ToString();
            investDateTB.Text = InvestData.DepositDateValue.ToString();

            investTypeCB.SelectedIndexChanged += investTypeCB_SelectedIndexChanged;
            investCurrencyCB.SelectedIndexChanged += investCurrencyCB_SelectedIndexChanged;
            investDateCB.SelectedIndexChanged += investDateCB_SelectedIndexChanged;
        }

        private void investTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvestData.DepositType = investTypeCB.SelectedIndex;
        }

        private void investCurrencyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvestData.DepositCurrency = investCurrencyCB.SelectedIndex;
        }

        private void investDateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvestData.DepositDateType = investDateCB.SelectedIndex;
        }

        private void cancelInputBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Вы точно хотите закрыть?", "Внимание!", 
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dlg == DialogResult.OK)
                this.Close();
        }

        private void confirmInputBtn_Click(object sender, EventArgs e)
        {
            DataValidation.GetInputValue(investValueTB.Text, out double currencyValue);
            DataValidation.GetInputDays(investDateTB.Text, out int term);

            if (currencyValue != 0 && term != 0)
            {
                DialogResult dlg = MessageBox.Show("Вы точно хотите подтвердить ваш выбор?","Подтверждение", 
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dlg == DialogResult.OK)
                {
                    InvestData.DepositCurValue = currencyValue;
                    InvestData.DepositDateValue = term;
                    this.Close();
                }
            }
            else MessageBox.Show("Проверьте правильность ввода!");
        }
    }
}
