namespace DataFilter
{
    partial class ProcessFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessFile));
            this.dataGridViewFile = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.linkLabelAdvancedSearch = new System.Windows.Forms.LinkLabel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.toolTiptitle = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripSelectedRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripBasicOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripExportOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportSelected = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile)).BeginInit();
            this.contextMenuStripSelectedRow.SuspendLayout();
            this.contextMenuStripBasicOptions.SuspendLayout();
            this.contextMenuStripExportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFile
            // 
            this.dataGridViewFile.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFile.Location = new System.Drawing.Point(12, 170);
            this.dataGridViewFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFile.Name = "dataGridViewFile";
            this.dataGridViewFile.RowHeadersWidth = 51;
            this.dataGridViewFile.RowTemplate.Height = 24;
            this.dataGridViewFile.Size = new System.Drawing.Size(1440, 577);
            this.dataGridViewFile.TabIndex = 0;
            this.dataGridViewFile.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridViewFile_AllowUserToAddRowsChanged);
            this.dataGridViewFile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFile_CellClick);
            this.dataGridViewFile.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFile_RowHeaderMouseClick);
            this.dataGridViewFile.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewFile_RowsAdded);
            this.dataGridViewFile.SelectionChanged += new System.EventHandler(this.dataGridViewFile_SelectionChanged);
            this.dataGridViewFile.Click += new System.EventHandler(this.dataGridViewFile_Click);
            this.dataGridViewFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFile_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(1413, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSearch.Location = new System.Drawing.Point(83, 94);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(189, 23);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.Text = "Search...";
            this.textBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseClick);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            this.textBoxSearch.MouseEnter += new System.EventHandler(this.textBoxSearch_MouseEnter);
            this.textBoxSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseUp);
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
            this.buttonSearch.Location = new System.Drawing.Point(291, 90);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(27, 26);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseHover += new System.EventHandler(this.buttonSearch_MouseHover);
            // 
            // linkLabelAdvancedSearch
            // 
            this.linkLabelAdvancedSearch.AutoSize = true;
            this.linkLabelAdvancedSearch.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkLabelAdvancedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelAdvancedSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelAdvancedSearch.LinkColor = System.Drawing.Color.Ivory;
            this.linkLabelAdvancedSearch.Location = new System.Drawing.Point(21, 138);
            this.linkLabelAdvancedSearch.Name = "linkLabelAdvancedSearch";
            this.linkLabelAdvancedSearch.Size = new System.Drawing.Size(140, 20);
            this.linkLabelAdvancedSearch.TabIndex = 28;
            this.linkLabelAdvancedSearch.TabStop = true;
            this.linkLabelAdvancedSearch.Text = "Advanced Search";
            this.linkLabelAdvancedSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdvancedSearch_LinkClicked);
            // 
            // buttonExport
            // 
            this.buttonExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExport.BackgroundImage")));
            this.buttonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Location = new System.Drawing.Point(1389, 122);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(45, 36);
            this.buttonExport.TabIndex = 29;
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            this.buttonExport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonExport_MouseClick);
            this.buttonExport.MouseHover += new System.EventHandler(this.buttonExport_MouseHover);
            // 
            // toolTiptitle
            // 
            this.toolTiptitle.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // contextMenuStripSelectedRow
            // 
            this.contextMenuStripSelectedRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSelectedRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelete,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemAddRow});
            this.contextMenuStripSelectedRow.Name = "contextMenuStripSelectedRow";
            this.contextMenuStripSelectedRow.Size = new System.Drawing.Size(140, 76);
            this.contextMenuStripSelectedRow.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripSelectedRow_ItemClicked);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(139, 24);
            this.toolStripMenuItemDelete.Text = "Delete";
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(139, 24);
            this.toolStripMenuItemEdit.Text = "Edit";
            // 
            // toolStripMenuItemAddRow
            // 
            this.toolStripMenuItemAddRow.Name = "toolStripMenuItemAddRow";
            this.toolStripMenuItemAddRow.Size = new System.Drawing.Size(139, 24);
            this.toolStripMenuItemAddRow.Text = "Add Row";
            // 
            // contextMenuStripBasicOptions
            // 
            this.contextMenuStripBasicOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripBasicOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd});
            this.contextMenuStripBasicOptions.Name = "contextMenuStripBasicOptions";
            this.contextMenuStripBasicOptions.Size = new System.Drawing.Size(140, 28);
            this.contextMenuStripBasicOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripBasicOptions_ItemClicked);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(139, 24);
            this.toolStripMenuItemAdd.Text = "Add Row";
            // 
            // contextMenuStripExportOptions
            // 
            this.contextMenuStripExportOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripExportOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportAll,
            this.toolStripMenuItemExportSelected});
            this.contextMenuStripExportOptions.Name = "contextMenuStripExportOptions";
            this.contextMenuStripExportOptions.Size = new System.Drawing.Size(183, 52);
            this.contextMenuStripExportOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripExportOptions_ItemClicked);
            // 
            // toolStripMenuItemExportAll
            // 
            this.toolStripMenuItemExportAll.Name = "toolStripMenuItemExportAll";
            this.toolStripMenuItemExportAll.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemExportAll.Text = "Export All";
            // 
            // toolStripMenuItemExportSelected
            // 
            this.toolStripMenuItemExportSelected.Name = "toolStripMenuItemExportSelected";
            this.toolStripMenuItemExportSelected.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemExportSelected.Text = "Export Selected";
            // 
            // ProcessFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1464, 759);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.linkLabelAdvancedSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProcessFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessFile";
            this.Load += new System.EventHandler(this.ProcessFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile)).EndInit();
            this.contextMenuStripSelectedRow.ResumeLayout(false);
            this.contextMenuStripBasicOptions.ResumeLayout(false);
            this.contextMenuStripExportOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.LinkLabel linkLabelAdvancedSearch;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ToolTip toolTiptitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSelectedRow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBasicOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddRow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripExportOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportSelected;
    }
}