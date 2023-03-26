namespace hostelRegistrationApp
{
    partial class frmListenToRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListenToRadio));
            this.lnkLbl1 = new System.Windows.Forms.LinkLabel();
            this.lnkLbl2 = new System.Windows.Forms.LinkLabel();
            this.lnkLbl3 = new System.Windows.Forms.LinkLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkLbl1
            // 
            this.lnkLbl1.AutoSize = true;
            this.lnkLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLbl1.LinkColor = System.Drawing.Color.Black;
            this.lnkLbl1.Location = new System.Drawing.Point(12, 285);
            this.lnkLbl1.Name = "lnkLbl1";
            this.lnkLbl1.Size = new System.Drawing.Size(64, 25);
            this.lnkLbl1.TabIndex = 0;
            this.lnkLbl1.TabStop = true;
            this.lnkLbl1.Text = "Music";
            this.lnkLbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbl1_LinkClicked);
            // 
            // lnkLbl2
            // 
            this.lnkLbl2.AutoSize = true;
            this.lnkLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLbl2.LinkColor = System.Drawing.Color.Black;
            this.lnkLbl2.Location = new System.Drawing.Point(82, 285);
            this.lnkLbl2.Name = "lnkLbl2";
            this.lnkLbl2.Size = new System.Drawing.Size(61, 25);
            this.lnkLbl2.TabIndex = 0;
            this.lnkLbl2.TabStop = true;
            this.lnkLbl2.Text = "News";
            this.lnkLbl2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbl2_LinkClicked);
            // 
            // lnkLbl3
            // 
            this.lnkLbl3.AutoSize = true;
            this.lnkLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLbl3.LinkColor = System.Drawing.Color.Black;
            this.lnkLbl3.Location = new System.Drawing.Point(149, 285);
            this.lnkLbl3.Name = "lnkLbl3";
            this.lnkLbl3.Size = new System.Drawing.Size(54, 25);
            this.lnkLbl3.TabIndex = 0;
            this.lnkLbl3.TabStop = true;
            this.lnkLbl3.Text = "Spor";
            this.lnkLbl3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbl3_LinkClicked);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, -3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(425, 268);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // frmListenToRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(426, 333);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lnkLbl3);
            this.Controls.Add(this.lnkLbl2);
            this.Controls.Add(this.lnkLbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListenToRadio";
            this.Text = "ListenToRadio";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkLbl1;
        private System.Windows.Forms.LinkLabel lnkLbl2;
        private System.Windows.Forms.LinkLabel lnkLbl3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}