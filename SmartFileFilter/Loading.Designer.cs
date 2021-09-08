namespace DataFilter
{
    partial class Loading
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
            this.circularProgressBarLoading = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // circularProgressBarLoading
            // 
            this.circularProgressBarLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarLoading.AnimationSpeed = 500;
            this.circularProgressBarLoading.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarLoading.InnerColor = System.Drawing.Color.DarkSlateGray;
            this.circularProgressBarLoading.InnerMargin = 2;
            this.circularProgressBarLoading.InnerWidth = -1;
            this.circularProgressBarLoading.Location = new System.Drawing.Point(184, 142);
            this.circularProgressBarLoading.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarLoading.Name = "circularProgressBarLoading";
            this.circularProgressBarLoading.OuterColor = System.Drawing.Color.White;
            this.circularProgressBarLoading.OuterMargin = -25;
            this.circularProgressBarLoading.OuterWidth = 25;
            this.circularProgressBarLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarLoading.ProgressWidth = 27;
            this.circularProgressBarLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarLoading.Size = new System.Drawing.Size(52, 52);
            this.circularProgressBarLoading.StartAngle = 270;
            this.circularProgressBarLoading.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBarLoading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarLoading.SubscriptText = ".23";
            this.circularProgressBarLoading.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBarLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarLoading.SuperscriptText = "°C";
            this.circularProgressBarLoading.TabIndex = 0;
            this.circularProgressBarLoading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarLoading.Value = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(80, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Will take a moment!";
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.circularProgressBarLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBarLoading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerLoad;
    }
}