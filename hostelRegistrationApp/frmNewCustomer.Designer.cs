namespace hostelRegistrationApp
{
    partial class frmNewCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpLeaving = new System.Windows.Forms.DateTimePicker();
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.MskTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtRoomNo = new System.Windows.Forms.TextBox();
            this.TxtIdNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnNo109 = new System.Windows.Forms.Button();
            this.BtnNo108 = new System.Windows.Forms.Button();
            this.BtnFullRoom = new System.Windows.Forms.Button();
            this.BtnNo106 = new System.Windows.Forms.Button();
            this.BtnNo107 = new System.Windows.Forms.Button();
            this.BtnNo105 = new System.Windows.Forms.Button();
            this.BtnEmptyRoom = new System.Windows.Forms.Button();
            this.BtnNo103 = new System.Windows.Forms.Button();
            this.BtnNo104 = new System.Windows.Forms.Button();
            this.BtnNo102 = new System.Windows.Forms.Button();
            this.BtnNo101 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtpLeaving);
            this.groupBox1.Controls.Add(this.dtpEntry);
            this.groupBox1.Controls.Add(this.MskTxtPhone);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.TxtRoomNo);
            this.groupBox1.Controls.Add(this.TxtIdNo);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtLastName);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(316, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 179);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(110, 63);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 245);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 19);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpLeaving
            // 
            this.dtpLeaving.Location = new System.Drawing.Point(110, 222);
            this.dtpLeaving.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLeaving.Name = "dtpLeaving";
            this.dtpLeaving.Size = new System.Drawing.Size(167, 20);
            this.dtpLeaving.TabIndex = 9;
            this.dtpLeaving.ValueChanged += new System.EventHandler(this.dtpLeaving_ValueChanged);
            // 
            // dtpEntry
            // 
            this.dtpEntry.Location = new System.Drawing.Point(110, 199);
            this.dtpEntry.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(167, 20);
            this.dtpEntry.TabIndex = 8;
            // 
            // MskTxtPhone
            // 
            this.MskTxtPhone.BackColor = System.Drawing.SystemColors.Info;
            this.MskTxtPhone.Location = new System.Drawing.Point(110, 85);
            this.MskTxtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.MskTxtPhone.Mask = "(999) 000-0000";
            this.MskTxtPhone.Name = "MskTxtPhone";
            this.MskTxtPhone.Size = new System.Drawing.Size(167, 20);
            this.MskTxtPhone.TabIndex = 3;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPrice.Enabled = false;
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPrice.Location = new System.Drawing.Point(110, 176);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(167, 19);
            this.TxtPrice.TabIndex = 7;
            // 
            // TxtRoomNo
            // 
            this.TxtRoomNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtRoomNo.Enabled = false;
            this.TxtRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRoomNo.Location = new System.Drawing.Point(110, 154);
            this.TxtRoomNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRoomNo.Name = "TxtRoomNo";
            this.TxtRoomNo.Size = new System.Drawing.Size(167, 19);
            this.TxtRoomNo.TabIndex = 6;
            // 
            // TxtIdNo
            // 
            this.TxtIdNo.BackColor = System.Drawing.SystemColors.Info;
            this.TxtIdNo.Location = new System.Drawing.Point(110, 131);
            this.TxtIdNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdNo.MaxLength = 11;
            this.TxtIdNo.Name = "TxtIdNo";
            this.TxtIdNo.Size = new System.Drawing.Size(167, 20);
            this.TxtIdNo.TabIndex = 5;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMail.Location = new System.Drawing.Point(110, 108);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(167, 20);
            this.TxtMail.TabIndex = 4;
            // 
            // TxtLastName
            // 
            this.TxtLastName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtLastName.Location = new System.Drawing.Point(110, 40);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(167, 20);
            this.TxtLastName.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtName.Location = new System.Drawing.Point(110, 17);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(167, 20);
            this.TxtName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Leaving Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date of Entry: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Room Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Identification Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mail :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnNo109);
            this.groupBox2.Controls.Add(this.BtnNo108);
            this.groupBox2.Controls.Add(this.BtnFullRoom);
            this.groupBox2.Controls.Add(this.BtnNo106);
            this.groupBox2.Controls.Add(this.BtnNo107);
            this.groupBox2.Controls.Add(this.BtnNo105);
            this.groupBox2.Controls.Add(this.BtnEmptyRoom);
            this.groupBox2.Controls.Add(this.BtnNo103);
            this.groupBox2.Controls.Add(this.BtnNo104);
            this.groupBox2.Controls.Add(this.BtnNo102);
            this.groupBox2.Controls.Add(this.BtnNo101);
            this.groupBox2.Location = new System.Drawing.Point(331, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(299, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rooms";
            // 
            // BtnNo109
            // 
            this.BtnNo109.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo109.Location = new System.Drawing.Point(205, 156);
            this.BtnNo109.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo109.Name = "BtnNo109";
            this.BtnNo109.Size = new System.Drawing.Size(77, 61);
            this.BtnNo109.TabIndex = 8;
            this.BtnNo109.Text = "109";
            this.BtnNo109.UseVisualStyleBackColor = false;
            this.BtnNo109.Click += new System.EventHandler(this.BtnNo109_Click);
            // 
            // BtnNo108
            // 
            this.BtnNo108.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo108.Location = new System.Drawing.Point(104, 155);
            this.BtnNo108.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo108.Name = "BtnNo108";
            this.BtnNo108.Size = new System.Drawing.Size(77, 61);
            this.BtnNo108.TabIndex = 7;
            this.BtnNo108.Text = "108";
            this.BtnNo108.UseVisualStyleBackColor = false;
            this.BtnNo108.Click += new System.EventHandler(this.BtnNo108_Click);
            // 
            // BtnFullRoom
            // 
            this.BtnFullRoom.BackColor = System.Drawing.Color.Red;
            this.BtnFullRoom.Location = new System.Drawing.Point(224, 245);
            this.BtnFullRoom.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFullRoom.Name = "BtnFullRoom";
            this.BtnFullRoom.Size = new System.Drawing.Size(58, 36);
            this.BtnFullRoom.TabIndex = 10;
            this.BtnFullRoom.Text = "Full";
            this.BtnFullRoom.UseVisualStyleBackColor = false;
            this.BtnFullRoom.Click += new System.EventHandler(this.BtnFullRoom_Click);
            // 
            // BtnNo106
            // 
            this.BtnNo106.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo106.Location = new System.Drawing.Point(205, 88);
            this.BtnNo106.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo106.Name = "BtnNo106";
            this.BtnNo106.Size = new System.Drawing.Size(77, 61);
            this.BtnNo106.TabIndex = 5;
            this.BtnNo106.Text = "106";
            this.BtnNo106.UseVisualStyleBackColor = false;
            this.BtnNo106.Click += new System.EventHandler(this.BtnNo106_Click);
            // 
            // BtnNo107
            // 
            this.BtnNo107.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo107.Location = new System.Drawing.Point(4, 156);
            this.BtnNo107.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo107.Name = "BtnNo107";
            this.BtnNo107.Size = new System.Drawing.Size(77, 61);
            this.BtnNo107.TabIndex = 6;
            this.BtnNo107.Text = "107";
            this.BtnNo107.UseVisualStyleBackColor = false;
            this.BtnNo107.Click += new System.EventHandler(this.BtnNo107_Click);
            // 
            // BtnNo105
            // 
            this.BtnNo105.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo105.Location = new System.Drawing.Point(104, 88);
            this.BtnNo105.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo105.Name = "BtnNo105";
            this.BtnNo105.Size = new System.Drawing.Size(77, 61);
            this.BtnNo105.TabIndex = 4;
            this.BtnNo105.Text = "105";
            this.BtnNo105.UseVisualStyleBackColor = false;
            this.BtnNo105.Click += new System.EventHandler(this.BtnNo105_Click);
            // 
            // BtnEmptyRoom
            // 
            this.BtnEmptyRoom.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnEmptyRoom.Location = new System.Drawing.Point(123, 245);
            this.BtnEmptyRoom.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEmptyRoom.Name = "BtnEmptyRoom";
            this.BtnEmptyRoom.Size = new System.Drawing.Size(58, 36);
            this.BtnEmptyRoom.TabIndex = 9;
            this.BtnEmptyRoom.Text = "Empty";
            this.BtnEmptyRoom.UseVisualStyleBackColor = false;
            this.BtnEmptyRoom.Click += new System.EventHandler(this.BtnEmptyRoom_Click);
            // 
            // BtnNo103
            // 
            this.BtnNo103.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo103.Location = new System.Drawing.Point(205, 17);
            this.BtnNo103.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo103.Name = "BtnNo103";
            this.BtnNo103.Size = new System.Drawing.Size(77, 58);
            this.BtnNo103.TabIndex = 2;
            this.BtnNo103.Text = "103";
            this.BtnNo103.UseVisualStyleBackColor = false;
            this.BtnNo103.Click += new System.EventHandler(this.BtnNo103_Click);
            // 
            // BtnNo104
            // 
            this.BtnNo104.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo104.Location = new System.Drawing.Point(4, 88);
            this.BtnNo104.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo104.Name = "BtnNo104";
            this.BtnNo104.Size = new System.Drawing.Size(77, 61);
            this.BtnNo104.TabIndex = 3;
            this.BtnNo104.Text = "104";
            this.BtnNo104.UseVisualStyleBackColor = false;
            this.BtnNo104.Click += new System.EventHandler(this.BtnNo104_Click);
            // 
            // BtnNo102
            // 
            this.BtnNo102.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo102.Location = new System.Drawing.Point(104, 17);
            this.BtnNo102.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo102.Name = "BtnNo102";
            this.BtnNo102.Size = new System.Drawing.Size(77, 58);
            this.BtnNo102.TabIndex = 1;
            this.BtnNo102.Text = "102";
            this.BtnNo102.UseVisualStyleBackColor = false;
            this.BtnNo102.Click += new System.EventHandler(this.BtnNo102_Click);
            // 
            // BtnNo101
            // 
            this.BtnNo101.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnNo101.Location = new System.Drawing.Point(4, 17);
            this.BtnNo101.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNo101.Name = "BtnNo101";
            this.BtnNo101.Size = new System.Drawing.Size(77, 61);
            this.BtnNo101.TabIndex = 0;
            this.BtnNo101.Text = "101";
            this.BtnNo101.UseVisualStyleBackColor = false;
            this.BtnNo101.Click += new System.EventHandler(this.BtnNo101_Click);
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(641, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.frmNewCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpLeaving;
        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.MaskedTextBox MskTxtPhone;
        private System.Windows.Forms.TextBox TxtRoomNo;
        private System.Windows.Forms.TextBox TxtIdNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnNo103;
        private System.Windows.Forms.Button BtnNo102;
        private System.Windows.Forms.Button BtnNo101;
        private System.Windows.Forms.Button BtnNo109;
        private System.Windows.Forms.Button BtnNo108;
        private System.Windows.Forms.Button BtnFullRoom;
        private System.Windows.Forms.Button BtnNo106;
        private System.Windows.Forms.Button BtnNo107;
        private System.Windows.Forms.Button BtnNo105;
        private System.Windows.Forms.Button BtnEmptyRoom;
        private System.Windows.Forms.Button BtnNo104;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}