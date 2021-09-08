namespace DataFilter
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.btnClose = new System.Windows.Forms.Button();
            this.menuMember = new System.Windows.Forms.MenuStrip();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStripUserProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelToSetGridView = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewShowNewFile = new System.Windows.Forms.DataGridView();
            this.btnTeamsClosed = new System.Windows.Forms.Button();
            this.contextMenuStripFileProcessOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilesHolder = new System.Windows.Forms.Panel();
            this.labelAddFiles = new System.Windows.Forms.Label();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.btnActivityClose = new System.Windows.Forms.Button();
            this.listBoxActivity = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelActivityLabel = new System.Windows.Forms.Label();
            this.btnFileProcessOptions = new System.Windows.Forms.Button();
            this.panelTeams = new System.Windows.Forms.Panel();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTeamsTitle = new System.Windows.Forms.Label();
            this.panelSaved = new System.Windows.Forms.Panel();
            this.btnSavedClose = new System.Windows.Forms.Button();
            this.listBoxSaved = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSavedTitle = new System.Windows.Forms.Label();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.buttonCloseFilesPanel = new System.Windows.Forms.Button();
            this.listBoxFilesList = new System.Windows.Forms.ListBox();
            this.contextMenuStripFilesOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilesTitle = new System.Windows.Forms.Label();
            this.tabControlToShowFiles = new System.Windows.Forms.TabControl();
            this.tabPageOverPanelToshowFiles = new System.Windows.Forms.TabPage();
            this.btnTabClose = new System.Windows.Forms.Button();
            this.btnMemberProfile = new DataFilter.RoundButton();
            this.menuMember.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStripUserProfile.SuspendLayout();
            this.panelToSetGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowNewFile)).BeginInit();
            this.contextMenuStripFileProcessOption.SuspendLayout();
            this.panelFilesHolder.SuspendLayout();
            this.panelActivity.SuspendLayout();
            this.panelTeams.SuspendLayout();
            this.panelSaved.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.contextMenuStripFilesOption.SuspendLayout();
            this.tabControlToShowFiles.SuspendLayout();
            this.tabPageOverPanelToshowFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(1514, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuMember
            // 
            this.menuMember.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMember.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityToolStripMenuItem,
            this.SavedToolStripMenuItem,
            this.filesToolStripMenuItem});
            this.menuMember.Location = new System.Drawing.Point(0, 0);
            this.menuMember.Name = "menuMember";
            this.menuMember.Padding = new System.Windows.Forms.Padding(10, 70, 2, 0);
            this.menuMember.Size = new System.Drawing.Size(162, 1264);
            this.menuMember.TabIndex = 2;
            this.menuMember.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.activityToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activityToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activityToolStripMenuItem.Image")));
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(137, 54);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // SavedToolStripMenuItem
            // 
            this.SavedToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SavedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SavedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SavedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SavedToolStripMenuItem.Image")));
            this.SavedToolStripMenuItem.Name = "SavedToolStripMenuItem";
            this.SavedToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.SavedToolStripMenuItem.Size = new System.Drawing.Size(137, 54);
            this.SavedToolStripMenuItem.Text = "Saved";
            this.SavedToolStripMenuItem.Click += new System.EventHandler(this.SavedToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.filesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filesToolStripMenuItem.Checked = true;
            this.filesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filesToolStripMenuItem.Image")));
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(137, 54);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnMemberProfile);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.panel1.Size = new System.Drawing.Size(1603, 71);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // contextMenuStripUserProfile
            // 
            this.contextMenuStripUserProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuStripUserProfile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripUserProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProfile,
            this.toolStripSeparator2,
            this.toolStripMenuItemLogOut});
            this.contextMenuStripUserProfile.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.contextMenuStripUserProfile.Name = "contextMenuStripUserProfile";
            this.contextMenuStripUserProfile.Size = new System.Drawing.Size(144, 66);
            // 
            // toolStripMenuItemProfile
            // 
            this.toolStripMenuItemProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemProfile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemProfile.Image")));
            this.toolStripMenuItemProfile.Name = "toolStripMenuItemProfile";
            this.toolStripMenuItemProfile.Size = new System.Drawing.Size(143, 28);
            this.toolStripMenuItemProfile.Text = "Profile";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // toolStripMenuItemLogOut
            // 
            this.toolStripMenuItemLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemLogOut.Name = "toolStripMenuItemLogOut";
            this.toolStripMenuItemLogOut.Size = new System.Drawing.Size(143, 28);
            this.toolStripMenuItemLogOut.Text = "Log out";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(423, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 789);
            this.panel2.TabIndex = 4;
            // 
            // panelToSetGridView
            // 
            this.panelToSetGridView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelToSetGridView.Controls.Add(this.btnSave);
            this.panelToSetGridView.Controls.Add(this.dataGridViewShowNewFile);
            this.panelToSetGridView.Location = new System.Drawing.Point(438, 96);
            this.panelToSetGridView.Name = "panelToSetGridView";
            this.panelToSetGridView.Size = new System.Drawing.Size(1115, 749);
            this.panelToSetGridView.TabIndex = 0;
            this.panelToSetGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToSetGridView_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewShowNewFile
            // 
            this.dataGridViewShowNewFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowNewFile.Location = new System.Drawing.Point(23, 53);
            this.dataGridViewShowNewFile.Name = "dataGridViewShowNewFile";
            this.dataGridViewShowNewFile.RowHeadersWidth = 51;
            this.dataGridViewShowNewFile.RowTemplate.Height = 24;
            this.dataGridViewShowNewFile.Size = new System.Drawing.Size(1068, 678);
            this.dataGridViewShowNewFile.TabIndex = 0;
            // 
            // btnTeamsClosed
            // 
            this.btnTeamsClosed.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTeamsClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTeamsClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeamsClosed.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnTeamsClosed.FlatAppearance.BorderSize = 0;
            this.btnTeamsClosed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTeamsClosed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTeamsClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamsClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTeamsClosed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTeamsClosed.Location = new System.Drawing.Point(230, 23);
            this.btnTeamsClosed.Name = "btnTeamsClosed";
            this.btnTeamsClosed.Size = new System.Drawing.Size(47, 41);
            this.btnTeamsClosed.TabIndex = 4;
            this.btnTeamsClosed.Text = "X";
            this.btnTeamsClosed.UseVisualStyleBackColor = false;
            this.btnTeamsClosed.Click += new System.EventHandler(this.btnTeamsClosed_Click_1);
            // 
            // contextMenuStripFileProcessOption
            // 
            this.contextMenuStripFileProcessOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripFileProcessOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSort,
            this.toolStripMenuItemExport});
            this.contextMenuStripFileProcessOption.Name = "contextMenuStripFileProcessOption";
            this.contextMenuStripFileProcessOption.Size = new System.Drawing.Size(126, 56);
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
            // panelFilesHolder
            // 
            this.panelFilesHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFilesHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFilesHolder.Controls.Add(this.labelAddFiles);
            this.panelFilesHolder.Controls.Add(this.buttonAddFiles);
            this.panelFilesHolder.Location = new System.Drawing.Point(17, 42);
            this.panelFilesHolder.Name = "panelFilesHolder";
            this.panelFilesHolder.Size = new System.Drawing.Size(1093, 678);
            this.panelFilesHolder.TabIndex = 6;
            // 
            // labelAddFiles
            // 
            this.labelAddFiles.AutoSize = true;
            this.labelAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelAddFiles.Location = new System.Drawing.Point(511, 259);
            this.labelAddFiles.Name = "labelAddFiles";
            this.labelAddFiles.Size = new System.Drawing.Size(207, 52);
            this.labelAddFiles.TabIndex = 1;
            this.labelAddFiles.Text = "Add new files  \nand start processing";
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddFiles.BackgroundImage")));
            this.buttonAddFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFiles.FlatAppearance.BorderSize = 0;
            this.buttonAddFiles.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddFiles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFiles.Location = new System.Drawing.Point(309, 211);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(145, 124);
            this.buttonAddFiles.TabIndex = 0;
            this.buttonAddFiles.UseVisualStyleBackColor = false;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // panelActivity
            // 
            this.panelActivity.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActivity.Controls.Add(this.btnActivityClose);
            this.panelActivity.Controls.Add(this.listBoxActivity);
            this.panelActivity.Controls.Add(this.label4);
            this.panelActivity.Controls.Add(this.labelActivityLabel);
            this.panelActivity.Location = new System.Drawing.Point(132, 77);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(280, 818);
            this.panelActivity.TabIndex = 8;
            this.panelActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.panelActivity_Paint);
            // 
            // btnActivityClose
            // 
            this.btnActivityClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivityClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActivityClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivityClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivityClose.FlatAppearance.BorderSize = 0;
            this.btnActivityClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivityClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivityClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivityClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnActivityClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivityClose.Location = new System.Drawing.Point(219, 25);
            this.btnActivityClose.Name = "btnActivityClose";
            this.btnActivityClose.Size = new System.Drawing.Size(47, 41);
            this.btnActivityClose.TabIndex = 5;
            this.btnActivityClose.Text = "X";
            this.btnActivityClose.UseVisualStyleBackColor = false;
            this.btnActivityClose.Click += new System.EventHandler(this.btnActivityClose_Click_1);
            // 
            // listBoxActivity
            // 
            this.listBoxActivity.AllowDrop = true;
            this.listBoxActivity.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listBoxActivity.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBoxActivity.FormattingEnabled = true;
            this.listBoxActivity.ItemHeight = 16;
            this.listBoxActivity.Location = new System.Drawing.Point(36, 103);
            this.listBoxActivity.Name = "listBoxActivity";
            this.listBoxActivity.Size = new System.Drawing.Size(220, 592);
            this.listBoxActivity.TabIndex = 12;
            this.listBoxActivity.SelectedIndexChanged += new System.EventHandler(this.listBoxActivity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
            this.label4.Location = new System.Drawing.Point(35, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 2);
            this.label4.TabIndex = 11;
            // 
            // labelActivityLabel
            // 
            this.labelActivityLabel.AutoSize = true;
            this.labelActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelActivityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelActivityLabel.Location = new System.Drawing.Point(31, 32);
            this.labelActivityLabel.Name = "labelActivityLabel";
            this.labelActivityLabel.Size = new System.Drawing.Size(86, 29);
            this.labelActivityLabel.TabIndex = 10;
            this.labelActivityLabel.Text = "Activity";
            // 
            // btnFileProcessOptions
            // 
            this.btnFileProcessOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFileProcessOptions.BackgroundImage")));
            this.btnFileProcessOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFileProcessOptions.ContextMenuStrip = this.contextMenuStripFileProcessOption;
            this.btnFileProcessOptions.FlatAppearance.BorderSize = 0;
            this.btnFileProcessOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileProcessOptions.Location = new System.Drawing.Point(46, 306);
            this.btnFileProcessOptions.Name = "btnFileProcessOptions";
            this.btnFileProcessOptions.Size = new System.Drawing.Size(42, 34);
            this.btnFileProcessOptions.TabIndex = 2;
            this.btnFileProcessOptions.UseVisualStyleBackColor = true;
            this.btnFileProcessOptions.Visible = false;
            this.btnFileProcessOptions.Click += new System.EventHandler(this.btnFileProcessOptions_Click);
            // 
            // panelTeams
            // 
            this.panelTeams.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTeams.Controls.Add(this.listBoxTeamMembers);
            this.panelTeams.Controls.Add(this.label3);
            this.panelTeams.Controls.Add(this.btnTeamsClosed);
            this.panelTeams.Controls.Add(this.labelTeamsTitle);
            this.panelTeams.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTeams.Location = new System.Drawing.Point(12, 433);
            this.panelTeams.Name = "panelTeams";
            this.panelTeams.Size = new System.Drawing.Size(287, 831);
            this.panelTeams.TabIndex = 9;
            this.panelTeams.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTeams_Paint);
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTeamMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxTeamMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBoxTeamMembers.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 22;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(34, 100);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(225, 660);
            this.listBoxTeamMembers.TabIndex = 4;
            this.listBoxTeamMembers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxTeamMembers_MouseDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
            this.label3.Location = new System.Drawing.Point(34, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 2);
            this.label3.TabIndex = 3;
            // 
            // labelTeamsTitle
            // 
            this.labelTeamsTitle.AutoSize = true;
            this.labelTeamsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTeamsTitle.Location = new System.Drawing.Point(30, 32);
            this.labelTeamsTitle.Name = "labelTeamsTitle";
            this.labelTeamsTitle.Size = new System.Drawing.Size(88, 29);
            this.labelTeamsTitle.TabIndex = 2;
            this.labelTeamsTitle.Text = "Teams";
            // 
            // panelSaved
            // 
            this.panelSaved.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaved.Controls.Add(this.btnSavedClose);
            this.panelSaved.Controls.Add(this.listBoxSaved);
            this.panelSaved.Controls.Add(this.label2);
            this.panelSaved.Controls.Add(this.labelSavedTitle);
            this.panelSaved.Location = new System.Drawing.Point(96, 290);
            this.panelSaved.Name = "panelSaved";
            this.panelSaved.Size = new System.Drawing.Size(287, 831);
            this.panelSaved.TabIndex = 9;
            this.panelSaved.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSaved_Paint);
            // 
            // btnSavedClose
            // 
            this.btnSavedClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSavedClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSavedClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavedClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSavedClose.FlatAppearance.BorderSize = 0;
            this.btnSavedClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSavedClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSavedClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavedClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSavedClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSavedClose.Location = new System.Drawing.Point(220, 24);
            this.btnSavedClose.Name = "btnSavedClose";
            this.btnSavedClose.Size = new System.Drawing.Size(47, 41);
            this.btnSavedClose.TabIndex = 6;
            this.btnSavedClose.Text = "X";
            this.btnSavedClose.UseVisualStyleBackColor = false;
            this.btnSavedClose.Click += new System.EventHandler(this.btnSavedClose_Click_1);
            // 
            // listBoxSaved
            // 
            this.listBoxSaved.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxSaved.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBoxSaved.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxSaved.FormattingEnabled = true;
            this.listBoxSaved.ItemHeight = 22;
            this.listBoxSaved.Location = new System.Drawing.Point(36, 115);
            this.listBoxSaved.Name = "listBoxSaved";
            this.listBoxSaved.Size = new System.Drawing.Size(220, 616);
            this.listBoxSaved.TabIndex = 5;
            this.listBoxSaved.SelectedIndexChanged += new System.EventHandler(this.listBoxSaved_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 2;
            // 
            // labelSavedTitle
            // 
            this.labelSavedTitle.AutoSize = true;
            this.labelSavedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSavedTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSavedTitle.Location = new System.Drawing.Point(22, 31);
            this.labelSavedTitle.Name = "labelSavedTitle";
            this.labelSavedTitle.Size = new System.Drawing.Size(87, 29);
            this.labelSavedTitle.TabIndex = 1;
            this.labelSavedTitle.Text = "Saved ";
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiles.Controls.Add(this.buttonCloseFilesPanel);
            this.panelFiles.Controls.Add(this.listBoxFilesList);
            this.panelFiles.Controls.Add(this.label1);
            this.panelFiles.Controls.Add(this.labelFilesTitle);
            this.panelFiles.Location = new System.Drawing.Point(48, 386);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(287, 831);
            this.panelFiles.TabIndex = 9;
            this.panelFiles.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFiles_Paint);
            // 
            // buttonCloseFilesPanel
            // 
            this.buttonCloseFilesPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCloseFilesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCloseFilesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseFilesPanel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonCloseFilesPanel.FlatAppearance.BorderSize = 0;
            this.buttonCloseFilesPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCloseFilesPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCloseFilesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseFilesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCloseFilesPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseFilesPanel.Location = new System.Drawing.Point(204, 23);
            this.buttonCloseFilesPanel.Name = "buttonCloseFilesPanel";
            this.buttonCloseFilesPanel.Size = new System.Drawing.Size(47, 41);
            this.buttonCloseFilesPanel.TabIndex = 3;
            this.buttonCloseFilesPanel.Text = "X";
            this.buttonCloseFilesPanel.UseVisualStyleBackColor = false;
            this.buttonCloseFilesPanel.Click += new System.EventHandler(this.buttonCloseFilesPanel_Click);
            // 
            // listBoxFilesList
            // 
            this.listBoxFilesList.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxFilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFilesList.ContextMenuStrip = this.contextMenuStripFilesOption;
            this.listBoxFilesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxFilesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBoxFilesList.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxFilesList.FormattingEnabled = true;
            this.listBoxFilesList.ItemHeight = 22;
            this.listBoxFilesList.Location = new System.Drawing.Point(29, 105);
            this.listBoxFilesList.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.listBoxFilesList.Name = "listBoxFilesList";
            this.listBoxFilesList.Size = new System.Drawing.Size(242, 660);
            this.listBoxFilesList.TabIndex = 2;
            this.listBoxFilesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFilesList_MouseClick);
            this.listBoxFilesList.SelectedIndexChanged += new System.EventHandler(this.listBoxFilesList_SelectedIndexChanged);
            this.listBoxFilesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFilesList_MouseDoubleClick);
            this.listBoxFilesList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxFilesList_MouseDown);
            // 
            // contextMenuStripFilesOption
            // 
            this.contextMenuStripFilesOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripFilesOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditFile,
            this.toolStripMenuItemDelete,
            this.toolStripSeparator1});
            this.contextMenuStripFilesOption.Name = "contextMenuStripFilesOption";
            this.contextMenuStripFilesOption.Size = new System.Drawing.Size(127, 62);
            this.contextMenuStripFilesOption.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripFilesOption_Opening);
            this.contextMenuStripFilesOption.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripFilesOption_ItemClicked);
            // 
            // toolStripMenuItemEditFile
            // 
            this.toolStripMenuItemEditFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemEditFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEditFile.Image")));
            this.toolStripMenuItemEditFile.Name = "toolStripMenuItemEditFile";
            this.toolStripMenuItemEditFile.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItemEditFile.Text = "Edit";
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDelete.Image")));
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItemDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.5F);
            this.label1.Location = new System.Drawing.Point(28, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 2);
            this.label1.TabIndex = 1;
            // 
            // labelFilesTitle
            // 
            this.labelFilesTitle.AutoSize = true;
            this.labelFilesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelFilesTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFilesTitle.Location = new System.Drawing.Point(24, 30);
            this.labelFilesTitle.Name = "labelFilesTitle";
            this.labelFilesTitle.Size = new System.Drawing.Size(66, 29);
            this.labelFilesTitle.TabIndex = 0;
            this.labelFilesTitle.Text = "Files";
            this.labelFilesTitle.Click += new System.EventHandler(this.labelFilesTitle_Click);
            // 
            // tabControlToShowFiles
            // 
            this.tabControlToShowFiles.Controls.Add(this.tabPageOverPanelToshowFiles);
            this.tabControlToShowFiles.Location = new System.Drawing.Point(603, 79);
            this.tabControlToShowFiles.Name = "tabControlToShowFiles";
            this.tabControlToShowFiles.SelectedIndex = 0;
            this.tabControlToShowFiles.Size = new System.Drawing.Size(1135, 755);
            this.tabControlToShowFiles.TabIndex = 3;
            this.tabControlToShowFiles.Visible = false;
            // 
            // tabPageOverPanelToshowFiles
            // 
            this.tabPageOverPanelToshowFiles.Controls.Add(this.btnTabClose);
            this.tabPageOverPanelToshowFiles.Controls.Add(this.panelFilesHolder);
            this.tabPageOverPanelToshowFiles.Location = new System.Drawing.Point(4, 25);
            this.tabPageOverPanelToshowFiles.Name = "tabPageOverPanelToshowFiles";
            this.tabPageOverPanelToshowFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverPanelToshowFiles.Size = new System.Drawing.Size(1127, 726);
            this.tabPageOverPanelToshowFiles.TabIndex = 0;
            this.tabPageOverPanelToshowFiles.Text = "Add";
            this.tabPageOverPanelToshowFiles.UseVisualStyleBackColor = true;
            // 
            // btnTabClose
            // 
            this.btnTabClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTabClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTabClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabClose.FlatAppearance.BorderSize = 0;
            this.btnTabClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTabClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTabClose.Location = new System.Drawing.Point(1060, 3);
            this.btnTabClose.Name = "btnTabClose";
            this.btnTabClose.Size = new System.Drawing.Size(47, 41);
            this.btnTabClose.TabIndex = 2;
            this.btnTabClose.Text = "X";
            this.btnTabClose.UseVisualStyleBackColor = false;
            this.btnTabClose.Visible = false;
            this.btnTabClose.Click += new System.EventHandler(this.btnTabClose_Click);
            // 
            // btnMemberProfile
            // 
            this.btnMemberProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMemberProfile.ContextMenuStrip = this.contextMenuStripUserProfile;
            this.btnMemberProfile.FlatAppearance.BorderSize = 0;
            this.btnMemberProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMemberProfile.Location = new System.Drawing.Point(1338, 13);
            this.btnMemberProfile.Name = "btnMemberProfile";
            this.btnMemberProfile.Size = new System.Drawing.Size(45, 45);
            this.btnMemberProfile.TabIndex = 5;
            this.btnMemberProfile.UseVisualStyleBackColor = false;
            this.btnMemberProfile.Click += new System.EventHandler(this.btnMemberProfile_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1942, 871);
            this.Controls.Add(this.panelTeams);
            this.Controls.Add(this.btnFileProcessOptions);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.tabControlToShowFiles);
            this.Controls.Add(this.panelSaved);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMember);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelToSetGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuMember;
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.menuMember.ResumeLayout(false);
            this.menuMember.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStripUserProfile.ResumeLayout(false);
            this.panelToSetGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowNewFile)).EndInit();
            this.contextMenuStripFileProcessOption.ResumeLayout(false);
            this.panelFilesHolder.ResumeLayout(false);
            this.panelFilesHolder.PerformLayout();
            this.panelActivity.ResumeLayout(false);
            this.panelActivity.PerformLayout();
            this.panelTeams.ResumeLayout(false);
            this.panelTeams.PerformLayout();
            this.panelSaved.ResumeLayout(false);
            this.panelSaved.PerformLayout();
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            this.contextMenuStripFilesOption.ResumeLayout(false);
            this.tabControlToShowFiles.ResumeLayout(false);
            this.tabPageOverPanelToshowFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuMember;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem SavedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelToSetGridView;
        private System.Windows.Forms.Panel panelFilesHolder;
        private System.Windows.Forms.Label labelAddFiles;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.Panel panelTeams;
        private System.Windows.Forms.Panel panelSaved;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFilesTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSavedTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelActivityLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTeamsTitle;
        private System.Windows.Forms.ListBox listBoxFilesList;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.ListBox listBoxActivity;
        private System.Windows.Forms.ListBox listBoxSaved;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFilesOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUserProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogOut;
        private RoundButton btnMemberProfile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFileProcessOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortAsc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortDesc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
        private System.Windows.Forms.TabControl tabControlToShowFiles;
        private System.Windows.Forms.TabPage tabPageOverPanelToshowFiles;
        private System.Windows.Forms.Button btnTabClose;
        private System.Windows.Forms.Button btnFileProcessOptions;
        private System.Windows.Forms.Button buttonCloseFilesPanel;
        private System.Windows.Forms.DataGridView dataGridViewShowNewFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTeamsClosed;
        private System.Windows.Forms.Button btnActivityClose;
        private System.Windows.Forms.Button btnSavedClose;
    }
}