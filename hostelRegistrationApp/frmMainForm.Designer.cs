namespace hostelRegistrationApp
{
    partial class frmMainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnRadio = new FontAwesome.Sharp.IconButton();
            this.btnChangePass = new FontAwesome.Sharp.IconButton();
            this.btnAdminLogin = new FontAwesome.Sharp.IconButton();
            this.btnNewCustomer = new FontAwesome.Sharp.IconButton();
            this.btnRooms = new FontAwesome.Sharp.IconButton();
            this.btnCustomers = new FontAwesome.Sharp.IconButton();
            this.btnCoutList = new FontAwesome.Sharp.IconButton();
            this.btnIncome = new FontAwesome.Sharp.IconButton();
            this.ıconbtnStock = new FontAwesome.Sharp.IconButton();
            this.btnPos = new FontAwesome.Sharp.IconButton();
            this.btnNews = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.btnExt = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHour.Location = new System.Drawing.Point(12, 29);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(40, 16);
            this.lblHour.TabIndex = 8;
            this.lblHour.Text = "Hour";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "username :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(92, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 16);
            this.lblUser.TabIndex = 12;
            // 
            // btnRadio
            // 
            this.btnRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRadio.FlatAppearance.BorderSize = 0;
            this.btnRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadio.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRadio.ForeColor = System.Drawing.Color.Black;
            this.btnRadio.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnRadio.IconColor = System.Drawing.Color.Black;
            this.btnRadio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRadio.IconSize = 35;
            this.btnRadio.Location = new System.Drawing.Point(1416, 81);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(134, 105);
            this.btnRadio.TabIndex = 13;
            this.btnRadio.Text = "Listen Radio";
            this.btnRadio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRadio.UseVisualStyleBackColor = false;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnChangePass.IconColor = System.Drawing.Color.Black;
            this.btnChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePass.IconSize = 35;
            this.btnChangePass.Location = new System.Drawing.Point(1276, 81);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(134, 105);
            this.btnChangePass.TabIndex = 13;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.Black;
            this.btnAdminLogin.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.btnAdminLogin.IconColor = System.Drawing.Color.Black;
            this.btnAdminLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdminLogin.IconSize = 35;
            this.btnAdminLogin.Location = new System.Drawing.Point(16, 81);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(134, 105);
            this.btnAdminLogin.TabIndex = 14;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewCustomer.FlatAppearance.BorderSize = 0;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnNewCustomer.IconColor = System.Drawing.Color.Black;
            this.btnNewCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewCustomer.IconSize = 35;
            this.btnNewCustomer.Location = new System.Drawing.Point(156, 81);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(134, 105);
            this.btnNewCustomer.TabIndex = 15;
            this.btnNewCustomer.Text = "Add New Customer";
            this.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRooms.ForeColor = System.Drawing.Color.Black;
            this.btnRooms.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnRooms.IconColor = System.Drawing.Color.Black;
            this.btnRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRooms.IconSize = 35;
            this.btnRooms.Location = new System.Drawing.Point(296, 81);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(134, 105);
            this.btnRooms.TabIndex = 16;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCustomers.IconColor = System.Drawing.Color.Black;
            this.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomers.IconSize = 35;
            this.btnCustomers.Location = new System.Drawing.Point(436, 81);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(134, 105);
            this.btnCustomers.TabIndex = 17;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCoutList
            // 
            this.btnCoutList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCoutList.FlatAppearance.BorderSize = 0;
            this.btnCoutList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoutList.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCoutList.ForeColor = System.Drawing.Color.Black;
            this.btnCoutList.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnCoutList.IconColor = System.Drawing.Color.Black;
            this.btnCoutList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCoutList.IconSize = 35;
            this.btnCoutList.Location = new System.Drawing.Point(576, 81);
            this.btnCoutList.Name = "btnCoutList";
            this.btnCoutList.Size = new System.Drawing.Size(134, 105);
            this.btnCoutList.TabIndex = 18;
            this.btnCoutList.Text = "C-Out List";
            this.btnCoutList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCoutList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCoutList.UseVisualStyleBackColor = false;
            this.btnCoutList.Click += new System.EventHandler(this.btnCoutList_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIncome.ForeColor = System.Drawing.Color.Black;
            this.btnIncome.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnIncome.IconColor = System.Drawing.Color.Black;
            this.btnIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncome.IconSize = 35;
            this.btnIncome.Location = new System.Drawing.Point(716, 81);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(134, 105);
            this.btnIncome.TabIndex = 19;
            this.btnIncome.Text = "Income/Cost";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // ıconbtnStock
            // 
            this.ıconbtnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ıconbtnStock.FlatAppearance.BorderSize = 0;
            this.ıconbtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconbtnStock.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconbtnStock.ForeColor = System.Drawing.Color.Black;
            this.ıconbtnStock.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.ıconbtnStock.IconColor = System.Drawing.Color.Black;
            this.ıconbtnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconbtnStock.IconSize = 35;
            this.ıconbtnStock.Location = new System.Drawing.Point(856, 81);
            this.ıconbtnStock.Name = "ıconbtnStock";
            this.ıconbtnStock.Size = new System.Drawing.Size(134, 105);
            this.ıconbtnStock.TabIndex = 20;
            this.ıconbtnStock.Text = "Stock";
            this.ıconbtnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ıconbtnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ıconbtnStock.UseVisualStyleBackColor = false;
            this.ıconbtnStock.Click += new System.EventHandler(this.ıconbtnStock_Click);
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.Turquoise;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPos.ForeColor = System.Drawing.Color.Black;
            this.btnPos.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnPos.IconColor = System.Drawing.Color.Black;
            this.btnPos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPos.IconSize = 35;
            this.btnPos.Location = new System.Drawing.Point(996, 81);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(134, 105);
            this.btnPos.TabIndex = 21;
            this.btnPos.Text = "Pos";
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNews.FlatAppearance.BorderSize = 0;
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNews.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNews.ForeColor = System.Drawing.Color.Black;
            this.btnNews.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnNews.IconColor = System.Drawing.Color.Black;
            this.btnNews.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNews.IconSize = 35;
            this.btnNews.Location = new System.Drawing.Point(1136, 81);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(134, 105);
            this.btnNews.TabIndex = 22;
            this.btnNews.Text = "News";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNews.UseVisualStyleBackColor = false;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.LightGray;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfo.IconColor = System.Drawing.Color.Black;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 35;
            this.btnInfo.Location = new System.Drawing.Point(1556, 81);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(134, 105);
            this.btnInfo.TabIndex = 23;
            this.btnInfo.Text = "About Me";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExt.ForeColor = System.Drawing.Color.Black;
            this.btnExt.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnExt.IconColor = System.Drawing.Color.Black;
            this.btnExt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExt.IconSize = 35;
            this.btnExt.Location = new System.Drawing.Point(1696, 81);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(134, 105);
            this.btnExt.TabIndex = 24;
            this.btnExt.Text = "Exit";
            this.btnExt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(1765, 699);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.ıconbtnStock);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnCoutList);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnRadio);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(22, 750);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Activated += new System.EventHandler(this.frmMainForm_Activated);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private FontAwesome.Sharp.IconButton btnRadio;
        private FontAwesome.Sharp.IconButton btnChangePass;
        private FontAwesome.Sharp.IconButton btnAdminLogin;
        private FontAwesome.Sharp.IconButton btnNewCustomer;
        private FontAwesome.Sharp.IconButton btnRooms;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private FontAwesome.Sharp.IconButton btnCoutList;
        private FontAwesome.Sharp.IconButton btnIncome;
        private FontAwesome.Sharp.IconButton ıconbtnStock;
        private FontAwesome.Sharp.IconButton btnPos;
        private FontAwesome.Sharp.IconButton btnNews;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton btnExt;
    }
}