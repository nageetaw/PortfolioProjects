namespace DataFilter
{
    partial class AdvancedSerach
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
            this.labelAll = new System.Windows.Forms.Label();
            this.labelAny = new System.Windows.Forms.Label();
            this.labelexcatPharse = new System.Windows.Forms.Label();
            this.labelExclude = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBoxAll = new System.Windows.Forms.TextBox();
            this.textBoxAny = new System.Windows.Forms.TextBox();
            this.textBoxExact = new System.Windows.Forms.TextBox();
            this.textBoxExclude = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAll.Location = new System.Drawing.Point(122, 128);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(155, 25);
            this.labelAll.TabIndex = 0;
            this.labelAll.Text = "All of these word";
            // 
            // labelAny
            // 
            this.labelAny.AutoSize = true;
            this.labelAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAny.Location = new System.Drawing.Point(122, 202);
            this.labelAny.Name = "labelAny";
            this.labelAny.Size = new System.Drawing.Size(168, 25);
            this.labelAny.TabIndex = 2;
            this.labelAny.Text = "Any of these word";
            // 
            // labelexcatPharse
            // 
            this.labelexcatPharse.AutoSize = true;
            this.labelexcatPharse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelexcatPharse.Location = new System.Drawing.Point(122, 275);
            this.labelexcatPharse.Name = "labelexcatPharse";
            this.labelexcatPharse.Size = new System.Drawing.Size(164, 25);
            this.labelexcatPharse.TabIndex = 3;
            this.labelexcatPharse.Text = "The exact pharse";
            // 
            // labelExclude
            // 
            this.labelExclude.AutoSize = true;
            this.labelExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelExclude.Location = new System.Drawing.Point(122, 352);
            this.labelExclude.Name = "labelExclude";
            this.labelExclude.Size = new System.Drawing.Size(182, 25);
            this.labelExclude.TabIndex = 4;
            this.labelExclude.Text = "Exclude these word";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTitle.Location = new System.Drawing.Point(311, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(251, 36);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Advanced Search";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
            this.label4.Location = new System.Drawing.Point(230, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 2);
            this.label4.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(800, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxAll
            // 
            this.textBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxAll.Location = new System.Drawing.Point(332, 131);
            this.textBoxAll.Name = "textBoxAll";
            this.textBoxAll.Size = new System.Drawing.Size(298, 24);
            this.textBoxAll.TabIndex = 14;
            // 
            // textBoxAny
            // 
            this.textBoxAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxAny.Location = new System.Drawing.Point(332, 204);
            this.textBoxAny.Name = "textBoxAny";
            this.textBoxAny.Size = new System.Drawing.Size(298, 24);
            this.textBoxAny.TabIndex = 15;
            // 
            // textBoxExact
            // 
            this.textBoxExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxExact.Location = new System.Drawing.Point(332, 277);
            this.textBoxExact.Name = "textBoxExact";
            this.textBoxExact.Size = new System.Drawing.Size(298, 24);
            this.textBoxExact.TabIndex = 16;
            // 
            // textBoxExclude
            // 
            this.textBoxExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxExclude.Location = new System.Drawing.Point(332, 354);
            this.textBoxExclude.Name = "textBoxExclude";
            this.textBoxExclude.Size = new System.Drawing.Size(298, 24);
            this.textBoxExclude.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(710, 482);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Orange;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(571, 482);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 36);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AdvancedSerach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(851, 541);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxExclude);
            this.Controls.Add(this.textBoxExact);
            this.Controls.Add(this.textBoxAny);
            this.Controls.Add(this.textBoxAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelExclude);
            this.Controls.Add(this.labelexcatPharse);
            this.Controls.Add(this.labelAny);
            this.Controls.Add(this.labelAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdvancedSerach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedSerach";
            this.Load += new System.EventHandler(this.AdvancedSerach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.Label labelAny;
        private System.Windows.Forms.Label labelexcatPharse;
        private System.Windows.Forms.Label labelExclude;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button buttonCancel;
        internal System.Windows.Forms.TextBox textBoxAll;
        internal System.Windows.Forms.TextBox textBoxAny;
        internal System.Windows.Forms.TextBox textBoxExact;
        internal System.Windows.Forms.TextBox textBoxExclude;
    }
}