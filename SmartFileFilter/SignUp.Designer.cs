namespace DataFilter
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAccType = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxAccType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnShowOrHide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderbirthdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAccountType = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderbirthdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAccountType)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(223, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 167);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(1043, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFirstName.Location = new System.Drawing.Point(341, 238);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(101, 24);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLastName.Location = new System.Drawing.Point(341, 308);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(99, 24);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelEmailAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmailAddress.Location = new System.Drawing.Point(341, 381);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(132, 24);
            this.labelEmailAddress.TabIndex = 4;
            this.labelEmailAddress.Text = "Email Address";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDOB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDOB.Location = new System.Drawing.Point(341, 585);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(110, 24);
            this.labelDOB.TabIndex = 5;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGender.Location = new System.Drawing.Point(341, 521);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(74, 24);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(435, 93);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(395, 39);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Sign Up Quick and Easy!";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelAccType
            // 
            this.labelAccType.AutoSize = true;
            this.labelAccType.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelAccType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAccType.Location = new System.Drawing.Point(337, 645);
            this.labelAccType.Name = "labelAccType";
            this.labelAccType.Size = new System.Drawing.Size(128, 24);
            this.labelAccType.TabIndex = 8;
            this.labelAccType.Text = "Account Type";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Orange;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateAccount.Location = new System.Drawing.Point(334, 757);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(438, 44);
            this.btnCreateAccount.TabIndex = 19;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // textFirstName
            // 
            this.textFirstName.AcceptsTab = true;
            this.textFirstName.BackColor = System.Drawing.Color.White;
            this.textFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textFirstName.ForeColor = System.Drawing.Color.Black;
            this.textFirstName.Location = new System.Drawing.Point(498, 238);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(274, 28);
            this.textFirstName.TabIndex = 10;
            this.textFirstName.Tag = "guest_name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AcceptsTab = true;
            this.textBoxLastName.BackColor = System.Drawing.Color.White;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxLastName.ForeColor = System.Drawing.Color.Black;
            this.textBoxLastName.Location = new System.Drawing.Point(498, 308);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(274, 28);
            this.textBoxLastName.TabIndex = 11;
            this.textBoxLastName.Tag = "guest_name";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.AcceptsTab = true;
            this.textBoxEmailAddress.BackColor = System.Drawing.Color.White;
            this.textBoxEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmailAddress.Location = new System.Drawing.Point(498, 379);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(274, 28);
            this.textBoxEmailAddress.TabIndex = 12;
            this.textBoxEmailAddress.Tag = "guest_name";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Customs"});
            this.comboBoxGender.Location = new System.Drawing.Point(498, 518);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(274, 30);
            this.comboBoxGender.TabIndex = 14;
            this.comboBoxGender.Text = "Select Gender";
            // 
            // comboBoxAccType
            // 
            this.comboBoxAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxAccType.FormattingEnabled = true;
            this.comboBoxAccType.Items.AddRange(new object[] {
            "Bussiness",
            "Personal"});
            this.comboBoxAccType.Location = new System.Drawing.Point(498, 645);
            this.comboBoxAccType.Name = "comboBoxAccType";
            this.comboBoxAccType.Size = new System.Drawing.Size(274, 30);
            this.comboBoxAccType.TabIndex = 18;
            this.comboBoxAccType.Text = "Select account type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(337, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AcceptsTab = true;
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(498, 449);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(274, 28);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.Tag = "guest_name";
            // 
            // btnShowOrHide
            // 
            this.btnShowOrHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowOrHide.FlatAppearance.BorderSize = 0;
            this.btnShowOrHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrHide.Location = new System.Drawing.Point(790, 450);
            this.btnShowOrHide.Name = "btnShowOrHide";
            this.btnShowOrHide.Size = new System.Drawing.Size(40, 28);
            this.btnShowOrHide.TabIndex = 18;
            this.btnShowOrHide.UseVisualStyleBackColor = true;
            this.btnShowOrHide.Click += new System.EventHandler(this.btnShowOrHide_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(315, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 2);
            this.label2.TabIndex = 19;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownHeight = 80;
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.IntegralHeight = false;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "March",
            "April",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxMonth.Location = new System.Drawing.Point(498, 585);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(88, 30);
            this.comboBoxMonth.TabIndex = 15;
            this.comboBoxMonth.Text = "Month";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownHeight = 80;
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.IntegralHeight = false;
            this.comboBoxYear.Location = new System.Drawing.Point(601, 585);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(88, 30);
            this.comboBoxYear.TabIndex = 16;
            this.comboBoxYear.Text = "Year";
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownHeight = 80;
            this.comboBoxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.IntegralHeight = false;
            this.comboBoxDay.Location = new System.Drawing.Point(706, 585);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(66, 30);
            this.comboBoxDay.TabIndex = 17;
            this.comboBoxDay.Text = "Day";
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderGender
            // 
            this.errorProviderGender.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderbirthdate
            // 
            this.errorProviderbirthdate.ContainerControl = this;
            // 
            // errorProviderAccountType
            // 
            this.errorProviderAccountType.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.btnShowOrHide);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAccType);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.labelAccType);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderbirthdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAccountType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAccType;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxAccType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnShowOrHide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderGender;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderbirthdate;
        private System.Windows.Forms.ErrorProvider errorProviderAccountType;
    }
}