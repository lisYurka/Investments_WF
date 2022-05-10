using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Invest.InvestForms;

namespace Invest
{
    public partial class Form1 : Form
    {
        public Form1()
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

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 300;
            string str = "Доход по вкладу";
            this.Text = str.Substring(0, i);
            i++;
            if (i > str.Length)
                i = 0;
        }
    }
}
