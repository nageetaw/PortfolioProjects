namespace DataFilter
{
    partial class SecurityCheck
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
            this.comboBoxSecurtyQues = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxSecurityAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.errorProviderSecurityQuestion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSecurityAnswer = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecurityQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecurityAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSecurtyQues
            // 
            this.comboBoxSecurtyQues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecurtyQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxSecurtyQues.FormattingEnabled = true;
            this.comboBoxSecurtyQues.Items.AddRange(new object[] {
            "What\'s your nickname ?",
            "What\'s the name of your first pet ?",
            "What\'s the name of your chilhood school ?"});
            this.comboBoxSecurtyQues.Location = new System.Drawing.Point(148, 191);
            this.comboBoxSecurtyQues.Name = "comboBoxSecurtyQues";
            this.comboBoxSecurtyQues.Size = new System.Drawing.Size(411, 30);
            this.comboBoxSecurtyQues.TabIndex = 0;
            this.comboBoxSecurtyQues.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecurtyQues_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.textBoxSecurityAns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.comboBoxSecurtyQues);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 370);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(144, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select a security question";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(223, 305);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(265, 44);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxSecurityAns
            // 
            this.textBoxSecurityAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSecurityAns.Location = new System.Drawing.Point(148, 244);
            this.textBoxSecurityAns.Name = "textBoxSecurityAns";
            this.textBoxSecurityAns.Size = new System.Drawing.Size(411, 28);
            this.textBoxSecurityAns.TabIndex = 2;
            this.textBoxSecurityAns.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(199, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 2);
            this.label1.TabIndex = 20;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTitle.Location = new System.Drawing.Point(217, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 36);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "One last step to go!";
            // 
            // errorProviderSecurityQuestion
            // 
            this.errorProviderSecurityQuestion.ContainerControl = this;
            // 
            // errorProviderSecurityAnswer
            // 
            this.errorProviderSecurityAnswer.ContainerControl = this;
            // 
            // SecurityCheck
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(713, 395);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecurityCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityCheck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityCheck_FormClosed);
            this.Load += new System.EventHandler(this.SecurityCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecurityQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecurityAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProviderSecurityQuestion;
        private System.Windows.Forms.ErrorProvider errorProviderSecurityAnswer;
        internal System.Windows.Forms.ComboBox comboBoxSecurtyQues;
        internal System.Windows.Forms.TextBox textBoxSecurityAns;
        private System.Windows.Forms.Label label2;
    }
}