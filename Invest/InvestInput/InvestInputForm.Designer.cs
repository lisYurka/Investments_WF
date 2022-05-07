namespace Invest.InvestInput
{
    partial class InvestInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.investTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.investCurrencyCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.investPercentTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.investDateTB = new System.Windows.Forms.TextBox();
            this.investDateCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmInputBtn = new System.Windows.Forms.Button();
            this.cancelInputBtn = new System.Windows.Forms.Button();
            this.investValueTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип вклада";
            // 
            // investTypeCB
            // 
            this.investTypeCB.AllowDrop = true;
            this.investTypeCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.investTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.investTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.investTypeCB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.investTypeCB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.investTypeCB.FormattingEnabled = true;
            this.investTypeCB.Items.AddRange(new object[] {
            "Отзывной",
            "Безотзывной"});
            this.investTypeCB.Location = new System.Drawing.Point(204, 21);
            this.investTypeCB.Name = "investTypeCB";
            this.investTypeCB.Size = new System.Drawing.Size(154, 33);
            this.investTypeCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма вклада";
            // 
            // investCurrencyCB
            // 
            this.investCurrencyCB.AllowDrop = true;
            this.investCurrencyCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.investCurrencyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.investCurrencyCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.investCurrencyCB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.investCurrencyCB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.investCurrencyCB.FormattingEnabled = true;
            this.investCurrencyCB.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "BYN"});
            this.investCurrencyCB.Location = new System.Drawing.Point(361, 76);
            this.investCurrencyCB.Name = "investCurrencyCB";
            this.investCurrencyCB.Size = new System.Drawing.Size(76, 33);
            this.investCurrencyCB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ставка";
            // 
            // investPercentTB
            // 
            this.investPercentTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.investPercentTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.investPercentTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.investPercentTB.Location = new System.Drawing.Point(204, 131);
            this.investPercentTB.Name = "investPercentTB";
            this.investPercentTB.Size = new System.Drawing.Size(154, 32);
            this.investPercentTB.TabIndex = 6;
            this.investPercentTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Срок вклада";
            // 
            // investDateTB
            // 
            this.investDateTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.investDateTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.investDateTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.investDateTB.Location = new System.Drawing.Point(204, 185);
            this.investDateTB.Name = "investDateTB";
            this.investDateTB.Size = new System.Drawing.Size(154, 32);
            this.investDateTB.TabIndex = 8;
            this.investDateTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // investDateCB
            // 
            this.investDateCB.AllowDrop = true;
            this.investDateCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.investDateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.investDateCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.investDateCB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.investDateCB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.investDateCB.FormattingEnabled = true;
            this.investDateCB.Items.AddRange(new object[] {
            "дней",
            "месяцев",
            "лет"});
            this.investDateCB.Location = new System.Drawing.Point(363, 185);
            this.investDateCB.Name = "investDateCB";
            this.investDateCB.Size = new System.Drawing.Size(103, 33);
            this.investDateCB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(361, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "% годовых";
            // 
            // confirmInputBtn
            // 
            this.confirmInputBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.confirmInputBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmInputBtn.Location = new System.Drawing.Point(74, 271);
            this.confirmInputBtn.Name = "confirmInputBtn";
            this.confirmInputBtn.Size = new System.Drawing.Size(113, 44);
            this.confirmInputBtn.TabIndex = 11;
            this.confirmInputBtn.Text = "Ок";
            this.confirmInputBtn.UseVisualStyleBackColor = true;
            this.confirmInputBtn.Click += new System.EventHandler(this.confirmInputBtn_Click);
            // 
            // cancelInputBtn
            // 
            this.cancelInputBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelInputBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelInputBtn.Location = new System.Drawing.Point(316, 271);
            this.cancelInputBtn.Name = "cancelInputBtn";
            this.cancelInputBtn.Size = new System.Drawing.Size(113, 44);
            this.cancelInputBtn.TabIndex = 12;
            this.cancelInputBtn.Text = "Отмена";
            this.cancelInputBtn.UseVisualStyleBackColor = true;
            this.cancelInputBtn.Click += new System.EventHandler(this.cancelInputBtn_Click);
            // 
            // investValueTB
            // 
            this.investValueTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.investValueTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.investValueTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.investValueTB.Location = new System.Drawing.Point(204, 76);
            this.investValueTB.Name = "investValueTB";
            this.investValueTB.Size = new System.Drawing.Size(154, 32);
            this.investValueTB.TabIndex = 13;
            this.investValueTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InvestInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 342);
            this.Controls.Add(this.investValueTB);
            this.Controls.Add(this.cancelInputBtn);
            this.Controls.Add(this.confirmInputBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.investDateCB);
            this.Controls.Add(this.investDateTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.investPercentTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.investCurrencyCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.investTypeCB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvestInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox investTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox investCurrencyCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox investPercentTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox investDateTB;
        private System.Windows.Forms.ComboBox investDateCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirmInputBtn;
        private System.Windows.Forms.Button cancelInputBtn;
        private System.Windows.Forms.TextBox investValueTB;
    }
}