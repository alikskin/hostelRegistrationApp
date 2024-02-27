namespace hostelRegistrationApp
{
    partial class frmCurrencyExchange
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
            this.lblUsd = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsdAlis = new System.Windows.Forms.Label();
            this.txtUsdSatis = new System.Windows.Forms.Label();
            this.txtEurAlis = new System.Windows.Forms.Label();
            this.txtEurSatis = new System.Windows.Forms.Label();
            this.lblGbp = new System.Windows.Forms.Label();
            this.txtGbpAlis = new System.Windows.Forms.Label();
            this.txtGbpSatis = new System.Windows.Forms.Label();
            this.cBoxCurrency = new System.Windows.Forms.ComboBox();
            this.gboxCurrency = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.TextBox();
            this.lblCurExchange = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblGiveAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Location = new System.Drawing.Point(199, 34);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(30, 13);
            this.lblUsd.TabIndex = 0;
            this.lblUsd.Text = "USD";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Location = new System.Drawing.Point(199, 56);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(30, 13);
            this.lblEur.TabIndex = 0;
            this.lblEur.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SATIS";
            // 
            // txtUsdAlis
            // 
            this.txtUsdAlis.AutoSize = true;
            this.txtUsdAlis.Location = new System.Drawing.Point(256, 34);
            this.txtUsdAlis.Name = "txtUsdAlis";
            this.txtUsdAlis.Size = new System.Drawing.Size(13, 13);
            this.txtUsdAlis.TabIndex = 0;
            this.txtUsdAlis.Text = "0";
            // 
            // txtUsdSatis
            // 
            this.txtUsdSatis.AutoSize = true;
            this.txtUsdSatis.Location = new System.Drawing.Point(318, 34);
            this.txtUsdSatis.Name = "txtUsdSatis";
            this.txtUsdSatis.Size = new System.Drawing.Size(13, 13);
            this.txtUsdSatis.TabIndex = 0;
            this.txtUsdSatis.Text = "0";
            // 
            // txtEurAlis
            // 
            this.txtEurAlis.AutoSize = true;
            this.txtEurAlis.Location = new System.Drawing.Point(256, 56);
            this.txtEurAlis.Name = "txtEurAlis";
            this.txtEurAlis.Size = new System.Drawing.Size(13, 13);
            this.txtEurAlis.TabIndex = 0;
            this.txtEurAlis.Text = "0";
            // 
            // txtEurSatis
            // 
            this.txtEurSatis.AutoSize = true;
            this.txtEurSatis.Location = new System.Drawing.Point(318, 56);
            this.txtEurSatis.Name = "txtEurSatis";
            this.txtEurSatis.Size = new System.Drawing.Size(13, 13);
            this.txtEurSatis.TabIndex = 0;
            this.txtEurSatis.Text = "0";
            // 
            // lblGbp
            // 
            this.lblGbp.AutoSize = true;
            this.lblGbp.Location = new System.Drawing.Point(199, 78);
            this.lblGbp.Name = "lblGbp";
            this.lblGbp.Size = new System.Drawing.Size(29, 13);
            this.lblGbp.TabIndex = 0;
            this.lblGbp.Text = "GBP";
            // 
            // txtGbpAlis
            // 
            this.txtGbpAlis.AutoSize = true;
            this.txtGbpAlis.Location = new System.Drawing.Point(256, 78);
            this.txtGbpAlis.Name = "txtGbpAlis";
            this.txtGbpAlis.Size = new System.Drawing.Size(13, 13);
            this.txtGbpAlis.TabIndex = 0;
            this.txtGbpAlis.Text = "0";
            // 
            // txtGbpSatis
            // 
            this.txtGbpSatis.AutoSize = true;
            this.txtGbpSatis.Location = new System.Drawing.Point(318, 78);
            this.txtGbpSatis.Name = "txtGbpSatis";
            this.txtGbpSatis.Size = new System.Drawing.Size(13, 13);
            this.txtGbpSatis.TabIndex = 0;
            this.txtGbpSatis.Text = "0";
            // 
            // cBoxCurrency
            // 
            this.cBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCurrency.FormattingEnabled = true;
            this.cBoxCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.cBoxCurrency.Location = new System.Drawing.Point(6, 39);
            this.cBoxCurrency.Name = "cBoxCurrency";
            this.cBoxCurrency.Size = new System.Drawing.Size(69, 21);
            this.cBoxCurrency.TabIndex = 1;
            this.cBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.cBoxCurrency_SelectedIndexChanged);
            // 
            // gboxCurrency
            // 
            this.gboxCurrency.Controls.Add(this.lblAmount);
            this.gboxCurrency.Controls.Add(this.lblCurExchange);
            this.gboxCurrency.Controls.Add(this.lblCurrency);
            this.gboxCurrency.Controls.Add(this.cBoxCurrency);
            this.gboxCurrency.Controls.Add(this.lblGiveAmount);
            this.gboxCurrency.Controls.Add(this.label2);
            this.gboxCurrency.Controls.Add(this.label1);
            this.gboxCurrency.Location = new System.Drawing.Point(94, 94);
            this.gboxCurrency.Name = "gboxCurrency";
            this.gboxCurrency.Size = new System.Drawing.Size(352, 259);
            this.gboxCurrency.TabIndex = 2;
            this.gboxCurrency.TabStop = false;
            this.gboxCurrency.Text = "TRY Change";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(133, 41);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.TextChanged += new System.EventHandler(this.lblAmount_TextChanged);
            this.lblAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lblAmount_KeyPress);
            // 
            // lblCurExchange
            // 
            this.lblCurExchange.AutoSize = true;
            this.lblCurExchange.Location = new System.Drawing.Point(258, 47);
            this.lblCurExchange.Name = "lblCurExchange";
            this.lblCurExchange.Size = new System.Drawing.Size(13, 13);
            this.lblCurExchange.TabIndex = 3;
            this.lblCurExchange.Text = "0";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(81, 47);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(13, 13);
            this.lblCurrency.TabIndex = 3;
            this.lblCurrency.Text = "0";
            this.lblCurrency.TextChanged += new System.EventHandler(this.lblCurrency_TextChanged);
            // 
            // lblGiveAmount
            // 
            this.lblGiveAmount.AutoSize = true;
            this.lblGiveAmount.Location = new System.Drawing.Point(258, 23);
            this.lblGiveAmount.Name = "lblGiveAmount";
            this.lblGiveAmount.Size = new System.Drawing.Size(74, 13);
            this.lblGiveAmount.TabIndex = 0;
            this.lblGiveAmount.Text = "Verilen Miktar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alınan Döviz Tutar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınan Döviz:";
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.gboxCurrency);
            this.Controls.Add(this.txtGbpSatis);
            this.Controls.Add(this.txtEurSatis);
            this.Controls.Add(this.txtUsdSatis);
            this.Controls.Add(this.txtGbpAlis);
            this.Controls.Add(this.txtEurAlis);
            this.Controls.Add(this.txtUsdAlis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGbp);
            this.Controls.Add(this.lblEur);
            this.Controls.Add(this.lblUsd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCurrencyExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Exchange";
            this.Load += new System.EventHandler(this.frmCurrencyExchange_Load);
            this.gboxCurrency.ResumeLayout(false);
            this.gboxCurrency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.Label lblEur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtUsdAlis;
        private System.Windows.Forms.Label txtUsdSatis;
        private System.Windows.Forms.Label txtEurAlis;
        private System.Windows.Forms.Label txtEurSatis;
        private System.Windows.Forms.Label lblGbp;
        private System.Windows.Forms.Label txtGbpAlis;
        private System.Windows.Forms.Label txtGbpSatis;
        private System.Windows.Forms.ComboBox cBoxCurrency;
        private System.Windows.Forms.GroupBox gboxCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox lblAmount;
        private System.Windows.Forms.Label lblCurExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGiveAmount;
    }
}