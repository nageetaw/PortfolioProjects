namespace DataFilter
{
    partial class FileProcessorMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileProcessorMessageBox));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGuestPanelTitle = new System.Windows.Forms.Button();
            this.labelGernalMessage = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
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
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(396, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGuestPanelTitle
            // 
            this.btnGuestPanelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuestPanelTitle.BackgroundImage")));
            this.btnGuestPanelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestPanelTitle.Enabled = false;
            this.btnGuestPanelTitle.FlatAppearance.BorderSize = 0;
            this.btnGuestPanelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestPanelTitle.Location = new System.Drawing.Point(12, 7);
            this.btnGuestPanelTitle.Name = "btnGuestPanelTitle";
            this.btnGuestPanelTitle.Size = new System.Drawing.Size(65, 52);
            this.btnGuestPanelTitle.TabIndex = 8;
            this.btnGuestPanelTitle.UseVisualStyleBackColor = true;
            // 
            // labelGernalMessage
            // 
            this.labelGernalMessage.AutoSize = true;
            this.labelGernalMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGernalMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGernalMessage.Location = new System.Drawing.Point(84, 81);
            this.labelGernalMessage.Name = "labelGernalMessage";
            this.labelGernalMessage.Size = new System.Drawing.Size(53, 20);
            this.labelGernalMessage.TabIndex = 9;
            this.labelGernalMessage.Text = "label1";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Orange;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOk.Location = new System.Drawing.Point(387, 149);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(48, 32);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FileProcessorMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(447, 193);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelGernalMessage);
            this.Controls.Add(this.btnGuestPanelTitle);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileProcessorMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileProcessorMessageBox";
            this.Load += new System.EventHandler(this.FileProcessorMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGuestPanelTitle;
        private System.Windows.Forms.Label labelGernalMessage;
        private System.Windows.Forms.Button btnOk;
    }
}