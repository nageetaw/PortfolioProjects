namespace DataFilter
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.linkLabelChangePassword = new System.Windows.Forms.LinkLabel();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.errorProviderbirthdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTiptip = new System.Windows.Forms.ToolTip(this.components);
            this.labelDob = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openFileDialogUpload = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderbirthdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(197, 53);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(125, 122);
            this.pictureBoxUserProfile.TabIndex = 0;
            this.pictureBoxUserProfile.TabStop = false;
            this.pictureBoxUserProfile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxUserProfile_MouseDoubleClick);
            this.pictureBoxUserProfile.MouseHover += new System.EventHandler(this.pictureBoxUserProfile_MouseHover);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserName.Location = new System.Drawing.Point(360, 114);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(100, 24);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "UserName";
            this.labelUserName.MouseHover += new System.EventHandler(this.labelUserName_MouseHover);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmail.Location = new System.Drawing.Point(364, 273);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(379, 29);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "abcdefgh@gmail.com";
            this.textBoxEmail.Visible = false;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.MouseHover += new System.EventHandler(this.textBoxEmail_MouseHover);
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
            this.btnClose.Location = new System.Drawing.Point(740, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEdit.Location = new System.Drawing.Point(720, 392);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 33);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUserId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserId.Location = new System.Drawing.Point(39, 65);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(100, 24);
            this.labelUserId.TabIndex = 10;
            this.labelUserId.Text = "UserName";
            this.labelUserId.MouseHover += new System.EventHandler(this.labelUserId_MouseHover);
            // 
            // labelAccountType
            // 
            this.labelAccountType.AutoSize = true;
            this.labelAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelAccountType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAccountType.Location = new System.Drawing.Point(39, 128);
            this.labelAccountType.Name = "labelAccountType";
            this.labelAccountType.Size = new System.Drawing.Size(100, 24);
            this.labelAccountType.TabIndex = 11;
            this.labelAccountType.Text = "UserName";
            this.labelAccountType.MouseHover += new System.EventHandler(this.labelAccountType_MouseHover);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Orange;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSaveChanges.Location = new System.Drawing.Point(637, 392);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(59, 33);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // linkLabelChangePassword
            // 
            this.linkLabelChangePassword.AutoSize = true;
            this.linkLabelChangePassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkLabelChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabelChangePassword.LinkColor = System.Drawing.Color.Ivory;
            this.linkLabelChangePassword.Location = new System.Drawing.Point(12, 407);
            this.linkLabelChangePassword.Name = "linkLabelChangePassword";
            this.linkLabelChangePassword.Size = new System.Drawing.Size(134, 18);
            this.linkLabelChangePassword.TabIndex = 13;
            this.linkLabelChangePassword.TabStop = true;
            this.linkLabelChangePassword.Text = "Change Password ";
            this.linkLabelChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePassword_LinkClicked);
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
            this.comboBoxMonth.Location = new System.Drawing.Point(364, 220);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(77, 30);
            this.comboBoxMonth.TabIndex = 16;
            this.comboBoxMonth.Text = "Month";
            this.comboBoxMonth.Visible = false;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownHeight = 80;
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.IntegralHeight = false;
            this.comboBoxYear.Location = new System.Drawing.Point(451, 220);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(69, 30);
            this.comboBoxYear.TabIndex = 17;
            this.comboBoxYear.Text = "Year";
            this.comboBoxYear.Visible = false;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownHeight = 80;
            this.comboBoxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.IntegralHeight = false;
            this.comboBoxDay.Location = new System.Drawing.Point(526, 220);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(66, 30);
            this.comboBoxDay.TabIndex = 18;
            this.comboBoxDay.Text = "Day";
            this.comboBoxDay.Visible = false;
            // 
            // errorProviderbirthdate
            // 
            this.errorProviderbirthdate.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDob.Location = new System.Drawing.Point(360, 225);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(53, 20);
            this.labelDob.TabIndex = 19;
            this.labelDob.Text = "label1";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(360, 275);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "label1";
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpload.BackgroundImage")));
            this.buttonUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpload.FlatAppearance.BorderSize = 0;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonUpload.Location = new System.Drawing.Point(197, 181);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(36, 34);
            this.buttonUpload.TabIndex = 22;
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Visible = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // openFileDialogUpload
            // 
            this.openFileDialogUpload.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.linkLabelChangePassword);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.labelAccountType);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderbirthdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelAccountType;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.LinkLabel linkLabelChangePassword;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ErrorProvider errorProviderbirthdate;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ToolTip toolTiptip;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialogUpload;
    }
}