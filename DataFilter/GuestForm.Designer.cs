namespace DataFilter
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelToSetGridViewGuest = new System.Windows.Forms.Panel();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.comboBoxEquality = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSerach = new System.Windows.Forms.TextBox();
            this.labelSelectField = new System.Windows.Forms.Label();
            this.comboBoxSelectField = new System.Windows.Forms.ComboBox();
            this.btnFileProcessOptions = new System.Windows.Forms.Button();
            this.lblAddFiles = new System.Windows.Forms.Label();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.dataGridViewShowTablesGuest = new System.Windows.Forms.DataGridView();
            this.labelAddFilesGuest = new System.Windows.Forms.Label();
            this.buttonAddFilesGuest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGuestName = new System.Windows.Forms.Label();
            this.contextMenuStripGuestFilesOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogGuest = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripHeaderOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToSetGridViewGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTablesGuest)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStripGuestFilesOption.SuspendLayout();
            this.contextMenuStripHeaderOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToSetGridViewGuest
            // 
            this.panelToSetGridViewGuest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelToSetGridViewGuest.Controls.Add(this.buttonShowAll);
            this.panelToSetGridViewGuest.Controls.Add(this.comboBoxEquality);
            this.panelToSetGridViewGuest.Controls.Add(this.buttonSearch);
            this.panelToSetGridViewGuest.Controls.Add(this.textBoxSerach);
            this.panelToSetGridViewGuest.Controls.Add(this.labelSelectField);
            this.panelToSetGridViewGuest.Controls.Add(this.comboBoxSelectField);
            this.panelToSetGridViewGuest.Controls.Add(this.btnFileProcessOptions);
            this.panelToSetGridViewGuest.Controls.Add(this.lblAddFiles);
            this.panelToSetGridViewGuest.Controls.Add(this.btnAddFiles);
            this.panelToSetGridViewGuest.Controls.Add(this.dataGridViewShowTablesGuest);
            this.panelToSetGridViewGuest.Location = new System.Drawing.Point(244, 37);
            this.panelToSetGridViewGuest.Name = "panelToSetGridViewGuest";
            this.panelToSetGridViewGuest.Size = new System.Drawing.Size(1127, 764);
            this.panelToSetGridViewGuest.TabIndex = 1;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(1004, 13);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(86, 37);
            this.buttonShowAll.TabIndex = 28;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // comboBoxEquality
            // 
            this.comboBoxEquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxEquality.FormattingEnabled = true;
            this.comboBoxEquality.Items.AddRange(new object[] {
            "Equal",
            "Not Equal"});
            this.comboBoxEquality.Location = new System.Drawing.Point(765, 25);
            this.comboBoxEquality.Name = "comboBoxEquality";
            this.comboBoxEquality.Size = new System.Drawing.Size(123, 28);
            this.comboBoxEquality.TabIndex = 27;
            this.comboBoxEquality.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(705, 25);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(33, 30);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSerach
            // 
            this.textBoxSerach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSerach.Location = new System.Drawing.Point(387, 25);
            this.textBoxSerach.Name = "textBoxSerach";
            this.textBoxSerach.Size = new System.Drawing.Size(312, 28);
            this.textBoxSerach.TabIndex = 23;
            this.textBoxSerach.Text = "Serach..";
            this.textBoxSerach.Visible = false;
            this.textBoxSerach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSerach_MouseClick);
            this.textBoxSerach.TextChanged += new System.EventHandler(this.textBoxSerach_TextChanged);
            // 
            // labelSelectField
            // 
            this.labelSelectField.AutoSize = true;
            this.labelSelectField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelSelectField.Location = new System.Drawing.Point(11, 71);
            this.labelSelectField.Name = "labelSelectField";
            this.labelSelectField.Size = new System.Drawing.Size(109, 24);
            this.labelSelectField.TabIndex = 5;
            this.labelSelectField.Text = "Select Field";
            this.labelSelectField.Visible = false;
            // 
            // comboBoxSelectField
            // 
            this.comboBoxSelectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSelectField.FormattingEnabled = true;
            this.comboBoxSelectField.Location = new System.Drawing.Point(126, 70);
            this.comboBoxSelectField.Name = "comboBoxSelectField";
            this.comboBoxSelectField.Size = new System.Drawing.Size(232, 28);
            this.comboBoxSelectField.TabIndex = 3;
            this.comboBoxSelectField.Visible = false;
            // 
            // btnFileProcessOptions
            // 
            this.btnFileProcessOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFileProcessOptions.BackgroundImage")));
            this.btnFileProcessOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFileProcessOptions.FlatAppearance.BorderSize = 0;
            this.btnFileProcessOptions.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFileProcessOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileProcessOptions.Location = new System.Drawing.Point(15, 3);
            this.btnFileProcessOptions.Name = "btnFileProcessOptions";
            this.btnFileProcessOptions.Size = new System.Drawing.Size(42, 34);
            this.btnFileProcessOptions.TabIndex = 2;
            this.btnFileProcessOptions.UseVisualStyleBackColor = true;
            this.btnFileProcessOptions.Visible = false;
            this.btnFileProcessOptions.Click += new System.EventHandler(this.btnFileProcessOptions_Click);
            // 
            // lblAddFiles
            // 
            this.lblAddFiles.AutoSize = true;
            this.lblAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAddFiles.Location = new System.Drawing.Point(610, 387);
            this.lblAddFiles.Name = "lblAddFiles";
            this.lblAddFiles.Size = new System.Drawing.Size(207, 52);
            this.lblAddFiles.TabIndex = 2;
            this.lblAddFiles.Text = "Add new files  \nand start processing";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFiles.BackgroundImage")));
            this.btnAddFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFiles.FlatAppearance.BorderSize = 0;
            this.btnAddFiles.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFiles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFiles.Location = new System.Drawing.Point(446, 340);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(145, 124);
            this.btnAddFiles.TabIndex = 1;
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // dataGridViewShowTablesGuest
            // 
            this.dataGridViewShowTablesGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewShowTablesGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowTablesGuest.Location = new System.Drawing.Point(15, 111);
            this.dataGridViewShowTablesGuest.Name = "dataGridViewShowTablesGuest";
            this.dataGridViewShowTablesGuest.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowTablesGuest.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShowTablesGuest.RowHeadersWidth = 51;
            this.dataGridViewShowTablesGuest.RowTemplate.Height = 24;
            this.dataGridViewShowTablesGuest.Size = new System.Drawing.Size(1100, 650);
            this.dataGridViewShowTablesGuest.TabIndex = 0;
            this.dataGridViewShowTablesGuest.Visible = false;
            this.dataGridViewShowTablesGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowTablesGuest_CellContentClick);
            this.dataGridViewShowTablesGuest.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShowTablesGuest_ColumnHeaderMouseClick);
            this.dataGridViewShowTablesGuest.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShowTablesGuest_RowHeaderMouseClick);
            // 
            // labelAddFilesGuest
            // 
            this.labelAddFilesGuest.AutoSize = true;
            this.labelAddFilesGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelAddFilesGuest.Location = new System.Drawing.Point(628, 362);
            this.labelAddFilesGuest.Name = "labelAddFilesGuest";
            this.labelAddFilesGuest.Size = new System.Drawing.Size(207, 52);
            this.labelAddFilesGuest.TabIndex = 1;
            this.labelAddFilesGuest.Text = "Add new files  \nand start processing";
            // 
            // buttonAddFilesGuest
            // 
            this.buttonAddFilesGuest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddFilesGuest.BackgroundImage")));
            this.buttonAddFilesGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddFilesGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFilesGuest.FlatAppearance.BorderSize = 0;
            this.buttonAddFilesGuest.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddFilesGuest.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddFilesGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFilesGuest.Location = new System.Drawing.Point(871, 335);
            this.buttonAddFilesGuest.Name = "buttonAddFilesGuest";
            this.buttonAddFilesGuest.Size = new System.Drawing.Size(96, 86);
            this.buttonAddFilesGuest.TabIndex = 0;
            this.buttonAddFilesGuest.UseVisualStyleBackColor = true;
            this.buttonAddFilesGuest.Click += new System.EventHandler(this.buttonAddFilesGuest_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1359, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.labelGuestName);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 815);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelGuestName
            // 
            this.labelGuestName.AutoSize = true;
            this.labelGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelGuestName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGuestName.Location = new System.Drawing.Point(46, 60);
            this.labelGuestName.Name = "labelGuestName";
            this.labelGuestName.Size = new System.Drawing.Size(100, 25);
            this.labelGuestName.TabIndex = 10;
            this.labelGuestName.Text = "Welcome ";
            // 
            // contextMenuStripGuestFilesOption
            // 
            this.contextMenuStripGuestFilesOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripGuestFilesOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSort,
            this.toolStripMenuItemExport});
            this.contextMenuStripGuestFilesOption.Name = "contextMenuStripFileProcessOption";
            this.contextMenuStripGuestFilesOption.Size = new System.Drawing.Size(126, 56);
            this.contextMenuStripGuestFilesOption.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripGuestFilesOption_Opening);
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSortAsc,
            this.toolStripMenuItemSortDesc});
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(125, 26);
            this.toolStripMenuItemSort.Text = "Sort";
            // 
            // toolStripMenuItemSortAsc
            // 
            this.toolStripMenuItemSortAsc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemSortAsc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSortAsc.Image")));
            this.toolStripMenuItemSortAsc.Name = "toolStripMenuItemSortAsc";
            this.toolStripMenuItemSortAsc.Size = new System.Drawing.Size(170, 26);
            this.toolStripMenuItemSortAsc.Text = "Ascending";
            // 
            // toolStripMenuItemSortDesc
            // 
            this.toolStripMenuItemSortDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemSortDesc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSortDesc.Image")));
            this.toolStripMenuItemSortDesc.Name = "toolStripMenuItemSortDesc";
            this.toolStripMenuItemSortDesc.Size = new System.Drawing.Size(170, 26);
            this.toolStripMenuItemSortDesc.Text = "Descending";
            // 
            // toolStripMenuItemExport
            // 
            this.toolStripMenuItemExport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemExport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemExport.Image")));
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(125, 26);
            this.toolStripMenuItemExport.Text = "Export";
            // 
            // openFileDialogGuest
            // 
            this.openFileDialogGuest.Filter = "\"txt files (*.csv)|*.txt|All files (*.*)|*.*\"";
            // 
            // contextMenuStripHeaderOptions
            // 
            this.contextMenuStripHeaderOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripHeaderOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSelectAll});
            this.contextMenuStripHeaderOptions.Name = "contextMenuStripHeaderOptions";
            this.contextMenuStripHeaderOptions.Size = new System.Drawing.Size(141, 28);
            this.contextMenuStripHeaderOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripHeaderOptions_ItemClicked);
            // 
            // toolStripMenuItemSelectAll
            // 
            this.toolStripMenuItemSelectAll.Name = "toolStripMenuItemSelectAll";
            this.toolStripMenuItemSelectAll.Size = new System.Drawing.Size(140, 24);
            this.toolStripMenuItemSelectAll.Text = "Select All";
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1398, 813);
            this.Controls.Add(this.panelToSetGridViewGuest);
            this.Controls.Add(this.labelAddFilesGuest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddFilesGuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panelToSetGridViewGuest.ResumeLayout(false);
            this.panelToSetGridViewGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTablesGuest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStripGuestFilesOption.ResumeLayout(false);
            this.contextMenuStripHeaderOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToSetGridViewGuest;
        private System.Windows.Forms.Button btnFileProcessOptions;
        private System.Windows.Forms.DataGridView dataGridViewShowTablesGuest;
        private System.Windows.Forms.Label labelAddFilesGuest;
        private System.Windows.Forms.Button buttonAddFilesGuest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGuestName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGuestFilesOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortAsc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortDesc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Label lblAddFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialogGuest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHeaderOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectAll;
        private System.Windows.Forms.Label labelSelectField;
        private System.Windows.Forms.ComboBox comboBoxSelectField;
        private System.Windows.Forms.ComboBox comboBoxEquality;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSerach;
        private System.Windows.Forms.Button buttonShowAll;
    }
}