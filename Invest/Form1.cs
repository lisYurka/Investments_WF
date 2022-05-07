using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Invest.InvestInput;

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
            DialogResult dlg_res = MessageBox.Show("Are you sure you want to exit ?", "Warning!", 
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg_res == DialogResult.Yes)
                Application.Exit();
        }
    }
}
