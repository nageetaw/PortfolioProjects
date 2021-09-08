namespace DataFilter
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnClose = new System.Windows.Forms.Button();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.btnUserIcon = new System.Windows.Forms.Button();
            this.textUserPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelMember = new System.Windows.Forms.Panel();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.btnShowOrHide = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUserPanelTitle = new System.Windows.Forms.Button();
            this.btnUserBack = new System.Windows.Forms.Button();
            this.panelGuest = new System.Windows.Forms.Panel();
            this.btnGuestPanelTitle = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStartTrial = new System.Windows.Forms.Button();
            this.textGuestName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderUserId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUserPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipTitle = new System.Windows.Forms.ToolTip(this.components);
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAsGuest = new System.Windows.Forms.Button();
            this.panelMember.SuspendLayout();
            this.panelGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClose.Location = new System.Drawing.Point(1231, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textUserId
            // 
            this.textUserId.AcceptsTab = true;
            this.textUserId.BackColor = System.Drawing.Color.White;
            this.textUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textUserId.ForeColor = System.Drawing.Color.Black;
            this.textUserId.Location = new System.Drawing.Point(106, 336);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(298, 30);
            this.textUserId.TabIndex = 1;
            this.textUserId.Tag = "user_id";
            this.textUserId.TextChanged += new System.EventHandler(this.textUserId_TextChanged);
            this.textUserId.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textUserId_MouseUp);
            // 
            // btnUserIcon
            // 
            this.btnUserIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUserIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserIcon.BackgroundImage")));
            this.btnUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserIcon.Enabled = false;
            this.btnUserIcon.FlatAppearance.BorderSize = 0;
            this.btnUserIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserIcon.Location = new System.Drawing.Point(60, 327);
            this.btnUserIcon.Name = "btnUserIcon";
            this.btnUserIcon.Size = new System.Drawing.Size(40, 39);
            this.btnUserIcon.TabIndex = 2;
            this.btnUserIcon.UseVisualStyleBackColor = false;
            // 
            // textUserPassword
            // 
            this.textUserPassword.AcceptsTab = true;
            this.textUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUserPassword.BackColor = System.Drawing.Color.White;
            this.textUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textUserPassword.ForeColor = System.Drawing.Color.Black;
            this.textUserPassword.Location = new System.Drawing.Point(106, 411);
            this.textUserPassword.Name = "textUserPassword";
            this.textUserPassword.PasswordChar = '*';
            this.textUserPassword.Size = new System.Drawing.Size(298, 30);
            this.textUserPassword.TabIndex = 2;
            this.textUserPassword.Tag = "user_password";
            this.textUserPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textUserPassword_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(60, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(12, 695);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(52, 46);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseHover += new System.EventHandler(this.btnAbout_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Ivory;
            this.linkLabel1.Location = new System.Drawing.Point(270, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelMember
            // 
            this.panelMember.Controls.Add(this.checkBoxRememberMe);
            this.panelMember.Controls.Add(this.btnShowOrHide);
            this.panelMember.Controls.Add(this.btnLogin);
            this.panelMember.Controls.Add(this.btnUserPanelTitle);
            this.panelMember.Controls.Add(this.btnUserBack);
            this.panelMember.Controls.Add(this.textUserId);
            this.panelMember.Controls.Add(this.linkLabel1);
            this.panelMember.Controls.Add(this.btnUserIcon);
            this.panelMember.Controls.Add(this.textUserPassword);
            this.panelMember.Controls.Add(this.button1);
            this.panelMember.Location = new System.Drawing.Point(748, 12);
            this.panelMember.Name = "panelMember";
            this.panelMember.Size = new System.Drawing.Size(477, 729);
            this.panelMember.TabIndex = 7;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkBoxRememberMe.Location = new System.Drawing.Point(106, 463);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(129, 22);
            this.checkBoxRememberMe.TabIndex = 20;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnShowOrHide
            // 
            this.btnShowOrHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowOrHide.FlatAppearance.BorderSize = 0;
            this.btnShowOrHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrHide.Location = new System.Drawing.Point(424, 411);
            this.btnShowOrHide.Name = "btnShowOrHide";
            this.btnShowOrHide.Size = new System.Drawing.Size(40, 28);
            this.btnShowOrHide.TabIndex = 19;
            this.btnShowOrHide.UseVisualStyleBackColor = true;
            this.btnShowOrHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Orange;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogin.Location = new System.Drawing.Point(185, 527);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUserPanelTitle
            // 
            this.btnUserPanelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserPanelTitle.BackgroundImage")));
            this.btnUserPanelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserPanelTitle.Enabled = false;
            this.btnUserPanelTitle.FlatAppearance.BorderSize = 0;
            this.btnUserPanelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserPanelTitle.Location = new System.Drawing.Point(169, 69);
            this.btnUserPanelTitle.Name = "btnUserPanelTitle";
            this.btnUserPanelTitle.Size = new System.Drawing.Size(207, 198);
            this.btnUserPanelTitle.TabIndex = 8;
            this.btnUserPanelTitle.UseVisualStyleBackColor = true;
            this.btnUserPanelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUserPanelTitle_MouseUp);
            // 
            // btnUserBack
            // 
            this.btnUserBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUserBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserBack.BackgroundImage")));
            this.btnUserBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserBack.FlatAppearance.BorderSize = 0;
            this.btnUserBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUserBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserBack.Location = new System.Drawing.Point(15, 14);
            this.btnUserBack.Name = "btnUserBack";
            this.btnUserBack.Size = new System.Drawing.Size(39, 29);
            this.btnUserBack.TabIndex = 7;
            this.btnUserBack.UseVisualStyleBackColor = false;
            this.btnUserBack.Click += new System.EventHandler(this.btnUserBack_Click);
            // 
            // panelGuest
            // 
            this.panelGuest.Controls.Add(this.btnGuestPanelTitle);
            this.panelGuest.Controls.Add(this.btnBack);
            this.panelGuest.Controls.Add(this.btnStartTrial);
            this.panelGuest.Controls.Add(this.textGuestName);
            this.panelGuest.Controls.Add(this.button2);
            this.panelGuest.Location = new System.Drawing.Point(609, 175);
            this.panelGuest.Name = "panelGuest";
            this.panelGuest.Size = new System.Drawing.Size(477, 729);
            this.panelGuest.TabIndex = 8;
            // 
            // btnGuestPanelTitle
            // 
            this.btnGuestPanelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestPanelTitle.BackgroundImage")));
            this.btnGuestPanelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestPanelTitle.Enabled = false;
            this.btnGuestPanelTitle.FlatAppearance.BorderSize = 0;
            this.btnGuestPanelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestPanelTitle.Location = new System.Drawing.Point(156, 70);
            this.btnGuestPanelTitle.Name = "btnGuestPanelTitle";
            this.btnGuestPanelTitle.Size = new System.Drawing.Size(207, 198);
            this.btnGuestPanelTitle.TabIndex = 7;
            this.btnGuestPanelTitle.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Location = new System.Drawing.Point(16, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStartTrial
            // 
            this.btnStartTrial.BackColor = System.Drawing.Color.Orange;
            this.btnStartTrial.FlatAppearance.BorderSize = 0;
            this.btnStartTrial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartTrial.Location = new System.Drawing.Point(172, 462);
            this.btnStartTrial.Name = "btnStartTrial";
            this.btnStartTrial.Size = new System.Drawing.Size(176, 44);
            this.btnStartTrial.TabIndex = 2;
            this.btnStartTrial.Text = "Start Trial";
            this.btnStartTrial.UseVisualStyleBackColor = false;
            this.btnStartTrial.Click += new System.EventHandler(this.btnStartTrial_Click);
            // 
            // textGuestName
            // 
            this.textGuestName.AcceptsTab = true;
            this.textGuestName.BackColor = System.Drawing.Color.White;
            this.textGuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textGuestName.ForeColor = System.Drawing.Color.Black;
            this.textGuestName.Location = new System.Drawing.Point(141, 374);
            this.textGuestName.Name = "textGuestName";
            this.textGuestName.Size = new System.Drawing.Size(274, 30);
            this.textGuestName.TabIndex = 1;
            this.textGuestName.Tag = "guest_name";
            this.textGuestName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textGuestName_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(62, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 46);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.Orange;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMember.Location = new System.Drawing.Point(164, 200);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(343, 44);
            this.btnMember.TabIndex = 4;
            this.btnMember.Text = "Log In";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(808, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(328, 327);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(267, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Not a member ?";
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(448, 399);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 43);
            this.button8.TabIndex = 15;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(157, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Log in and start to filter";
            // 
            // errorProviderUserId
            // 
            this.errorProviderUserId.ContainerControl = this;
            // 
            // errorProviderUserPassword
            // 
            this.errorProviderUserPassword.ContainerControl = this;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Orange;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSignUp.Location = new System.Drawing.Point(230, 397);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(191, 44);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(304, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Or ";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(174, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 43);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAsGuest
            // 
            this.btnAsGuest.BackColor = System.Drawing.Color.Orange;
            this.btnAsGuest.FlatAppearance.BorderSize = 0;
            this.btnAsGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAsGuest.Location = new System.Drawing.Point(230, 524);
            this.btnAsGuest.Name = "btnAsGuest";
            this.btnAsGuest.Size = new System.Drawing.Size(191, 44);
            this.btnAsGuest.TabIndex = 3;
            this.btnAsGuest.Text = "Guest";
            this.btnAsGuest.UseVisualStyleBackColor = false;
            this.btnAsGuest.Click += new System.EventHandler(this.btnAsGuest_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panelGuest);
            this.Controls.Add(this.panelMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAsGuest);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelMember.ResumeLayout(false);
            this.panelMember.PerformLayout();
            this.panelGuest.ResumeLayout(false);
            this.panelGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.Button btnUserIcon;
        private System.Windows.Forms.TextBox textUserPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelMember;
        private System.Windows.Forms.Panel panelGuest;
        private System.Windows.Forms.Button btnStartTrial;
        private System.Windows.Forms.TextBox textGuestName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnUserBack;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUserPanelTitle;
        private System.Windows.Forms.Button btnGuestPanelTitle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProviderUserId;
        private System.Windows.Forms.ErrorProvider errorProviderUserPassword;
        private System.Windows.Forms.Button btnShowOrHide;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ToolTip toolTipTitle;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsGuest;
    }
}

