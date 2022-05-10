using System;
using System.Windows.Forms;

using Invest.InvestForms;

namespace Invest
{
    public partial class MainForm : Form
    {
        private int charIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InvestInputForm().ShowDialog();
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg_res = MessageBox.Show("Вы точно хотите выйти?", "Внимание!", 
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg_res == DialogResult.Yes)
                Application.Exit();
        }

        private void calculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalculationForm().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 300;
            string str = "Доход по вкладу";
            this.Text = str.Substring(0, charIndex);
            charIndex ++;
            if (charIndex > str.Length)
                charIndex = 0;
        }
    }
}
