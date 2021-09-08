namespace DataFilter
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.axWindowsMediaPlayerIntroduction = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerIntroduction)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayerIntroduction
            // 
            this.axWindowsMediaPlayerIntroduction.Enabled = true;
            this.axWindowsMediaPlayerIntroduction.Location = new System.Drawing.Point(-2, -1);
            this.axWindowsMediaPlayerIntroduction.Name = "axWindowsMediaPlayerIntroduction";
            this.axWindowsMediaPlayerIntroduction.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerIntroduction.OcxState")));
            this.axWindowsMediaPlayerIntroduction.Size = new System.Drawing.Size(879, 552);
            this.axWindowsMediaPlayerIntroduction.TabIndex = 0;
            this.axWindowsMediaPlayerIntroduction.UseWaitCursor = true;
            this.axWindowsMediaPlayerIntroduction.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayerIntroduction_PlayStateChange);
            this.axWindowsMediaPlayerIntroduction.Enter += new System.EventHandler(this.axWindowsMediaPlayerIntroduction_Enter);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 555);
            this.Controls.Add(this.axWindowsMediaPlayerIntroduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerIntroduction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerIntroduction;
    }
}