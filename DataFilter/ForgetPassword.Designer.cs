namespace DataFilter
{
    partial class ForgetPassword
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
            this.panelVerifyId = new System.Windows.Forms.Panel();
            this.btnVerifyIdClose = new System.Windows.Forms.Button();
            this.btnVerifyUserID = new System.Windows.Forms.Button();
            this.textBoxVerifyId = new System.Windows.Forms.TextBox();
            this.labelUseridTitle = new System.Windows.Forms.Label();
            this.panelVerifyAnswer = new System.Windows.Forms.Panel();
            this.btnVerfyAnswerClose = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnVerifyAnswer = new System.Windows.Forms.Button();
            this.textBoxVerifyAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.buttonShowRepeatPass = new System.Windows.Forms.Button();
            this.buttonShowPass = new System.Windows.Forms.Button();
            this.textBoxRepeatPass = new System.Windows.Forms.TextBox();
            this.labelRepeatPasword = new System.Windows.Forms.Label();
            this.buttonPasswordChangeClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelVerifyId.SuspendLayout();
            this.panelVerifyAnswer.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVerifyId
            // 
            this.panelVerifyId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelVerifyId.Controls.Add(this.btnVerifyIdClose);
            this.panelVerifyId.Controls.Add(this.btnVerifyUserID);
            this.panelVerifyId.Controls.Add(this.textBoxVerifyId);
            this.panelVerifyId.Controls.Add(this.labelUseridTitle);
            this.panelVerifyId.Location = new System.Drawing.Point(27, 27);
            this.panelVerifyId.Name = "panelVerifyId";
            this.panelVerifyId.Size = new System.Drawing.Size(749, 398);
            this.panelVerifyId.TabIndex = 0;
            // 
            // btnVerifyIdClose
            // 
            this.btnVerifyIdClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerifyIdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerifyIdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyIdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerifyIdClose.FlatAppearance.BorderSize = 0;
            this.btnVerifyIdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyIdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVerifyIdClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerifyIdClose.Location = new System.Drawing.Point(709, 3);
            this.btnVerifyIdClose.Name = "btnVerifyIdClose";
            this.btnVerifyIdClose.Size = new System.Drawing.Size(37, 38);
            this.btnVerifyIdClose.TabIndex = 6;
            this.btnVerifyIdClose.Text = "X";
            this.btnVerifyIdClose.UseVisualStyleBackColor = false;
            this.btnVerifyIdClose.Click += new System.EventHandler(this.btnVerifyIdClose_Click);
            // 
            // btnVerifyUserID
            // 
            this.btnVerifyUserID.BackColor = System.Drawing.Color.Orange;
            this.btnVerifyUserID.FlatAppearance.BorderSize = 0;
            this.btnVerifyUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerifyUserID.Location = new System.Drawing.Point(234, 213);
            this.btnVerifyUserID.Name = "btnVerifyUserID";
            this.btnVerifyUserID.Size = new System.Drawing.Size(230, 43);
            this.btnVerifyUserID.TabIndex = 4;
            this.btnVerifyUserID.Text = "Submit";
            this.btnVerifyUserID.UseVisualStyleBackColor = false;
            this.btnVerifyUserID.Click += new System.EventHandler(this.btnVerifyUserID_Click);
            // 
            // textBoxVerifyId
            // 
            this.textBoxVerifyId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVerifyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxVerifyId.Location = new System.Drawing.Point(234, 149);
            this.textBoxVerifyId.Name = "textBoxVerifyId";
            this.textBoxVerifyId.Size = new System.Drawing.Size(230, 28);
            this.textBoxVerifyId.TabIndex = 1;
            this.textBoxVerifyId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUseridTitle
            // 
            this.labelUseridTitle.AutoSize = true;
            this.labelUseridTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUseridTitle.Location = new System.Drawing.Point(263, 105);
            this.labelUseridTitle.Name = "labelUseridTitle";
            this.labelUseridTitle.Size = new System.Drawing.Size(159, 24);
            this.labelUseridTitle.TabIndex = 0;
            this.labelUseridTitle.Text = "Enter your user Id";
            // 
            // panelVerifyAnswer
            // 
            this.panelVerifyAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelVerifyAnswer.Controls.Add(this.btnVerfyAnswerClose);
            this.panelVerifyAnswer.Controls.Add(this.labelUserName);
            this.panelVerifyAnswer.Controls.Add(this.btnVerifyAnswer);
            this.panelVerifyAnswer.Controls.Add(this.textBoxVerifyAnswer);
            this.panelVerifyAnswer.Controls.Add(this.label2);
            this.panelVerifyAnswer.Location = new System.Drawing.Point(12, 166);
            this.panelVerifyAnswer.Name = "panelVerifyAnswer";
            this.panelVerifyAnswer.Size = new System.Drawing.Size(749, 398);
            this.panelVerifyAnswer.TabIndex = 5;
            this.panelVerifyAnswer.Visible = false;
            this.panelVerifyAnswer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVerifyAnswer_Paint);
            // 
            // btnVerfyAnswerClose
            // 
            this.btnVerfyAnswerClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerfyAnswerClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerfyAnswerClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerfyAnswerClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerfyAnswerClose.FlatAppearance.BorderSize = 0;
            this.btnVerfyAnswerClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerfyAnswerClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVerfyAnswerClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerfyAnswerClose.Location = new System.Drawing.Point(701, 3);
            this.btnVerfyAnswerClose.Name = "btnVerfyAnswerClose";
            this.btnVerfyAnswerClose.Size = new System.Drawing.Size(45, 38);
            this.btnVerfyAnswerClose.TabIndex = 7;
            this.btnVerfyAnswerClose.Text = "X";
            this.btnVerfyAnswerClose.UseVisualStyleBackColor = false;
            this.btnVerfyAnswerClose.Click += new System.EventHandler(this.btnVerfyAnswerClose_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUserName.Location = new System.Drawing.Point(70, 50);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 24);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "label3";
            // 
            // btnVerifyAnswer
            // 
            this.btnVerifyAnswer.BackColor = System.Drawing.Color.Orange;
            this.btnVerifyAnswer.FlatAppearance.BorderSize = 0;
            this.btnVerifyAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerifyAnswer.Location = new System.Drawing.Point(234, 213);
            this.btnVerifyAnswer.Name = "btnVerifyAnswer";
            this.btnVerifyAnswer.Size = new System.Drawing.Size(230, 43);
            this.btnVerifyAnswer.TabIndex = 4;
            this.btnVerifyAnswer.Text = "Verify";
            this.btnVerifyAnswer.UseVisualStyleBackColor = false;
            this.btnVerifyAnswer.Click += new System.EventHandler(this.btnVerifyAnswer_Click);
            // 
            // textBoxVerifyAnswer
            // 
            this.textBoxVerifyAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVerifyAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxVerifyAnswer.Location = new System.Drawing.Point(234, 154);
            this.textBoxVerifyAnswer.Name = "textBoxVerifyAnswer";
            this.textBoxVerifyAnswer.Size = new System.Drawing.Size(230, 28);
            this.textBoxVerifyAnswer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(263, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 0;
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelChangePassword.Controls.Add(this.buttonShowRepeatPass);
            this.panelChangePassword.Controls.Add(this.buttonShowPass);
            this.panelChangePassword.Controls.Add(this.textBoxRepeatPass);
            this.panelChangePassword.Controls.Add(this.labelRepeatPasword);
            this.panelChangePassword.Controls.Add(this.buttonPasswordChangeClose);
            this.panelChangePassword.Controls.Add(this.buttonSave);
            this.panelChangePassword.Controls.Add(this.textBoxNewPass);
            this.panelChangePassword.Controls.Add(this.labelNewPassword);
            this.panelChangePassword.Location = new System.Drawing.Point(115, 12);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(749, 398);
            this.panelChangePassword.TabIndex = 6;
            this.panelChangePassword.Visible = false;
            // 
            // buttonShowRepeatPass
            // 
            this.buttonShowRepeatPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShowRepeatPass.FlatAppearance.BorderSize = 0;
            this.buttonShowRepeatPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowRepeatPass.Location = new System.Drawing.Point(552, 177);
            this.buttonShowRepeatPass.Name = "buttonShowRepeatPass";
            this.buttonShowRepeatPass.Size = new System.Drawing.Size(40, 26);
            this.buttonShowRepeatPass.TabIndex = 21;
            this.buttonShowRepeatPass.UseVisualStyleBackColor = true;
            this.buttonShowRepeatPass.Click += new System.EventHandler(this.buttonShowRepeatPass_Click);
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShowPass.FlatAppearance.BorderSize = 0;
            this.buttonShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPass.Location = new System.Drawing.Point(552, 130);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(40, 27);
            this.buttonShowPass.TabIndex = 20;
            this.buttonShowPass.UseVisualStyleBackColor = true;
            this.buttonShowPass.Click += new System.EventHandler(this.buttonShowPass_Click);
            // 
            // textBoxRepeatPass
            // 
            this.textBoxRepeatPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRepeatPass.Location = new System.Drawing.Point(303, 177);
            this.textBoxRepeatPass.Name = "textBoxRepeatPass";
            this.textBoxRepeatPass.PasswordChar = '*';
            this.textBoxRepeatPass.Size = new System.Drawing.Size(230, 26);
            this.textBoxRepeatPass.TabIndex = 8;
            // 
            // labelRepeatPasword
            // 
            this.labelRepeatPasword.AutoSize = true;
            this.labelRepeatPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRepeatPasword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRepeatPasword.Location = new System.Drawing.Point(131, 183);
            this.labelRepeatPasword.Name = "labelRepeatPasword";
            this.labelRepeatPasword.Size = new System.Drawing.Size(141, 20);
            this.labelRepeatPasword.TabIndex = 7;
            this.labelRepeatPasword.Text = "Repeat Password";
            // 
            // buttonPasswordChangeClose
            // 
            this.buttonPasswordChangeClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPasswordChangeClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPasswordChangeClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPasswordChangeClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPasswordChangeClose.FlatAppearance.BorderSize = 0;
            this.buttonPasswordChangeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPasswordChangeClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonPasswordChangeClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPasswordChangeClose.Location = new System.Drawing.Point(700, 3);
            this.buttonPasswordChangeClose.Name = "buttonPasswordChangeClose";
            this.buttonPasswordChangeClose.Size = new System.Drawing.Size(37, 38);
            this.buttonPasswordChangeClose.TabIndex = 6;
            this.buttonPasswordChangeClose.Text = "X";
            this.buttonPasswordChangeClose.UseVisualStyleBackColor = false;
            this.buttonPasswordChangeClose.Click += new System.EventHandler(this.buttonPasswordChangeClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Orange;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(303, 240);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(230, 43);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNewPass.Location = new System.Drawing.Point(303, 131);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.PasswordChar = '*';
            this.textBoxNewPass.Size = new System.Drawing.Size(230, 26);
            this.textBoxNewPass.TabIndex = 1;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNewPassword.Location = new System.Drawing.Point(151, 131);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(121, 20);
            this.labelNewPassword.TabIndex = 0;
            this.labelNewPassword.Text = "New Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelVerifyId);
            this.Controls.Add(this.panelVerifyAnswer);
            this.Controls.Add(this.panelChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.panelVerifyId.ResumeLayout(false);
            this.panelVerifyId.PerformLayout();
            this.panelVerifyAnswer.ResumeLayout(false);
            this.panelVerifyAnswer.PerformLayout();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVerifyId;
        private System.Windows.Forms.TextBox textBoxVerifyId;
        private System.Windows.Forms.Label labelUseridTitle;
        private System.Windows.Forms.Panel panelVerifyAnswer;
        private System.Windows.Forms.Button btnVerifyAnswer;
        private System.Windows.Forms.TextBox textBoxVerifyAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerifyUserID;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button btnVerifyIdClose;
        private System.Windows.Forms.Button btnVerfyAnswerClose;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.TextBox textBoxRepeatPass;
        private System.Windows.Forms.Label labelRepeatPasword;
        private System.Windows.Forms.Button buttonPasswordChangeClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button buttonShowRepeatPass;
        private System.Windows.Forms.Button buttonShowPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}