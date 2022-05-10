
namespace Invest.InvestForms
{
    partial class CalculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGB = new System.Windows.Forms.GroupBox();
            this.noBanksLb = new System.Windows.Forms.Label();
            this.depositCurrencyLb = new System.Windows.Forms.Label();
            this.dateValueLb = new System.Windows.Forms.Label();
            this.depositValueLb = new System.Windows.Forms.Label();
            this.depositTypeLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.userDataGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankName,
            this.DepositName,
            this.StartValue,
            this.Date,
            this.Percentage,
            this.EarnValue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(818, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // BankName
            // 
            this.BankName.HeaderText = "Банк";
            this.BankName.MinimumWidth = 6;
            this.BankName.Name = "BankName";
            this.BankName.Width = 71;
            // 
            // DepositName
            // 
            this.DepositName.HeaderText = "Название";
            this.DepositName.MinimumWidth = 6;
            this.DepositName.Name = "DepositName";
            this.DepositName.Width = 106;
            // 
            // StartValue
            // 
            this.StartValue.HeaderText = "Сумма";
            this.StartValue.MinimumWidth = 6;
            this.StartValue.Name = "StartValue";
            this.StartValue.Width = 84;
            // 
            // Date
            // 
            this.Date.HeaderText = "Срок";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 72;
            // 
            // Percentage
            // 
            this.Percentage.HeaderText = "Cтавка, год";
            this.Percentage.MinimumWidth = 6;
            this.Percentage.Name = "Percentage";
            this.Percentage.Width = 114;
            // 
            // EarnValue
            // 
            this.EarnValue.HeaderText = "Доход";
            this.EarnValue.MinimumWidth = 6;
            this.EarnValue.Name = "EarnValue";
            this.EarnValue.Width = 81;
            // 
            // userDataGB
            // 
            this.userDataGB.BackColor = System.Drawing.SystemColors.Control;
            this.userDataGB.Controls.Add(this.noBanksLb);
            this.userDataGB.Controls.Add(this.depositCurrencyLb);
            this.userDataGB.Controls.Add(this.dateValueLb);
            this.userDataGB.Controls.Add(this.depositValueLb);
            this.userDataGB.Controls.Add(this.depositTypeLb);
            this.userDataGB.Location = new System.Drawing.Point(12, 12);
            this.userDataGB.Name = "userDataGB";
            this.userDataGB.Size = new System.Drawing.Size(818, 115);
            this.userDataGB.TabIndex = 1;
            this.userDataGB.TabStop = false;
            this.userDataGB.Text = "Данные";
            // 
            // noBanksLb
            // 
            this.noBanksLb.AutoSize = true;
            this.noBanksLb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noBanksLb.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.noBanksLb.ForeColor = System.Drawing.Color.IndianRed;
            this.noBanksLb.Location = new System.Drawing.Point(164, 85);
            this.noBanksLb.Name = "noBanksLb";
            this.noBanksLb.Size = new System.Drawing.Size(0, 25);
            this.noBanksLb.TabIndex = 4;
            // 
            // depositCurrencyLb
            // 
            this.depositCurrencyLb.AutoSize = true;
            this.depositCurrencyLb.Location = new System.Drawing.Point(394, 23);
            this.depositCurrencyLb.Name = "depositCurrencyLb";
            this.depositCurrencyLb.Size = new System.Drawing.Size(0, 20);
            this.depositCurrencyLb.TabIndex = 3;
            // 
            // dateValueLb
            // 
            this.dateValueLb.AutoSize = true;
            this.dateValueLb.Location = new System.Drawing.Point(645, 23);
            this.dateValueLb.Name = "dateValueLb";
            this.dateValueLb.Size = new System.Drawing.Size(134, 20);
            this.dateValueLb.TabIndex = 2;
            this.dateValueLb.Text = "Срок вклада (дни)";
            // 
            // depositValueLb
            // 
            this.depositValueLb.AutoSize = true;
            this.depositValueLb.Location = new System.Drawing.Point(345, 23);
            this.depositValueLb.Name = "depositValueLb";
            this.depositValueLb.Size = new System.Drawing.Size(55, 20);
            this.depositValueLb.TabIndex = 1;
            this.depositValueLb.Text = "Сумма";
            // 
            // depositTypeLb
            // 
            this.depositTypeLb.AutoSize = true;
            this.depositTypeLb.Location = new System.Drawing.Point(89, 23);
            this.depositTypeLb.Name = "depositTypeLb";
            this.depositTypeLb.Size = new System.Drawing.Size(86, 20);
            this.depositTypeLb.TabIndex = 0;
            this.depositTypeLb.Text = "Тип вклада";
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 441);
            this.Controls.Add(this.userDataGB);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вычисления";
            this.Load += new System.EventHandler(this.CalculationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.userDataGB.ResumeLayout(false);
            this.userDataGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox userDataGB;
        private System.Windows.Forms.Label depositCurrencyLb;
        private System.Windows.Forms.Label dateValueLb;
        private System.Windows.Forms.Label depositValueLb;
        private System.Windows.Forms.Label depositTypeLb;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarnValue;
        private System.Windows.Forms.Label noBanksLb;
    }
}