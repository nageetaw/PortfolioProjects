namespace DataFilter
{
    partial class UserChoice
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
            this.btnConfrim = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfrim
            // 
            this.btnConfrim.BackColor = System.Drawing.Color.Orange;
            this.btnConfrim.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfrim.FlatAppearance.BorderSize = 0;
            this.btnConfrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConfrim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfrim.Location = new System.Drawing.Point(243, 112);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(68, 31);
            this.btnConfrim.TabIndex = 12;
            this.btnConfrim.Text = "Delete";
            this.btnConfrim.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(334, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 31);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMessage.Location = new System.Drawing.Point(69, 54);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(58, 20);
            this.labelMessage.TabIndex = 14;
            this.labelMessage.Text = "Delete";
            // 
            // UserChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(418, 155);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfrim);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confrimation";
            this.Load += new System.EventHandler(this.UserChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfrim;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelMessage;
    }
}