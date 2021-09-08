namespace DataFilter
{
    partial class StartUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            this.button1 = new System.Windows.Forms.Button();
            this.timerStartUp = new System.Windows.Forms.Timer(this.components);
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.timerTwo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(163, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 184);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timerStartUp
            // 
            this.timerStartUp.Enabled = true;
            this.timerStartUp.Interval = 1000;
            this.timerStartUp.Tick += new System.EventHandler(this.timerStartUp_Tick);
            // 
            // btnOne
            // 
            this.btnOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOne.BackgroundImage")));
            this.btnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Location = new System.Drawing.Point(190, 219);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(26, 30);
            this.btnOne.TabIndex = 2;
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwo.BackgroundImage")));
            this.btnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Location = new System.Drawing.Point(213, 219);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(26, 30);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThree.BackgroundImage")));
            this.btnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Location = new System.Drawing.Point(235, 219);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(26, 30);
            this.btnThree.TabIndex = 4;
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFour.BackgroundImage")));
            this.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Location = new System.Drawing.Point(257, 219);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(26, 30);
            this.btnFour.TabIndex = 5;
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFive.BackgroundImage")));
            this.btnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Location = new System.Drawing.Point(278, 219);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(26, 30);
            this.btnFive.TabIndex = 6;
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSix.BackgroundImage")));
            this.btnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Location = new System.Drawing.Point(300, 219);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(26, 30);
            this.btnSix.TabIndex = 7;
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // timerTwo
            // 
            this.timerTwo.Enabled = true;
            this.timerTwo.Interval = 5000;
            this.timerTwo.Tick += new System.EventHandler(this.timerTwo_Tick);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartUpForm";
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerStartUp;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Timer timerTwo;
    }
}