using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DataFilter
{
    public partial class Member : Form
    {
        Button setting;
        Button LogOut;
        DataSet dataset;
        DataColumn[] columns;
        User user;
        linqtosqlDataContext dataContext;
        List<UserActivit> usersActivities;
        List<Button> CloseTabButtonList;
        List<DataGridView> DataGridViewCollection;
        List<ComboBox> dataTypeBox;
        String[] fields;
        DataTable table;
        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        UserProfile profile;
        List<DataTable> tables;
        FileProcessorMessageBox FileProcessorMessageBoxForm;

        public Member(User user)
        {
            InitializeComponent();
            this.user = user;
            this.btnMemberProfile.Text = user.FirstName.Substring(0, 1);
            this.CloseTabButtonList = new List<Button>();
            this.DataGridViewCollection = new List<DataGridView>();
            this.tables = new List<DataTable>();


        }
        public Member() { InitializeComponent(); this.CloseTabButtonList = new List<Button>(); this.DataGridViewCollection = new List<DataGridView>(); }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnForword_Click(object sender, EventArgs e)
        {

        }

        private void CloseOtherPanels()
        {

            this.panelFiles.Visible = false;
            this.panelSaved.Visible = false;
            this.panelActivity.Visible = false;
            this.panelTeams.Visible = false;
        }
        private void ResizeFileHolderPanel()
        {
            this.tabControlToShowFiles.Location = this.panel2.Location;
            this.tabControlToShowFiles.Size = this.panel2.Size;

            this.xAxix = this.panel2.Location.X;
            this.width = this.panel2.Width;

        }
        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherPanels();
            ResizeFileHolderPanel();
            this.panelFiles.Visible = true;


            closeCenterPanels();

            this.tabControlToShowFiles.Visible = true;

        }
        private void closeCenterPanels()
        {
            this.panel2.Visible = false;
            this.panelToSetGridView.Visible = false;
            this.tabControlToShowFiles.Visible = false;
           // this.panelTeamsHolder.Visible = false;

        }

        private void SavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherPanels();
            this.panelSaved.Visible = true;


            closeCenterPanels();
            this.panelToSetGridView.Visible = true;


        }
        protected void Gernalbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // identify which button was clicked and perform necessary actions
            switch (button.Text)
            {
                case "File1":

                    this.panelToSetGridView.Visible = true;



                    break;

            }
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }
        ContextMenuStrip contextMenuProfile = new ContextMenuStrip();
        private void btnMemberProfile_Click(object sender, EventArgs e)
        {

            this.contextMenuStripUserProfile.Show(btnMemberProfile, new Point(11, setting.Height + 10));

        }
        private void LogOut_Click(object sender, EventArgs e)
        {

        }
        private void setting_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FillDataTables() {

            // filling datatables list with user stored tables
            connectionString = ConfigurationManager.ConnectionStrings["CString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            String query = "SELECT * FROM  UserFile where userid ='" + user.Id + "'";
            command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            String tableName, fetchTable;

            SqlDataReader tableReader;
            SqlCommand cmd;
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();

            while (reader.Read())
            {
                try
                {
                    tableName = reader.GetString(2).Trim();
                    fetchTable = "SELECT * FROM " + tableName + user.Id.Trim() + "";
                    cmd = new SqlCommand(fetchTable, sqlConnection);
                    //MessageBox.Show(tableName + user.Id);
                    tableReader = cmd.ExecuteReader();

                    DataTable table = new DataTable();
                    table.TableName = tableName;
                    table.Load(tableReader);
                    this.tables.Add(table);
                }
                catch (SqlException sqlex)
                {
                    FileProcessorMessageBoxForm.Show(sqlex.Message);
                    FileProcessorMessageBoxForm.ShowDialog();
                }
            }
            connection.Close();
            sqlConnection.Close();


        }
        private void Member_Load(object sender, EventArgs e)
        {
            setting = new Button();
            LogOut = new Button();
            dataContext = new linqtosqlDataContext();
            FileProcessorMessageBoxForm = new FileProcessorMessageBox();

         // load user activities
            var query1 = from act in dataContext.UserActivits where act.UserId == user.Id select act;
            foreach (var item in query1)
            {
                if (item.Activity != null)
                    this.listBoxActivity.Items.Add(item.Activity.Trim());

            }

            // load user files
            var query2 = from filedata in dataContext.UserFiles where filedata.UserId.Trim() == user.Id.Trim() select filedata;
            foreach (var file in query2)
            {

                this.listBoxFilesList.Items.Add(file.TableName.ToString().Trim());

            }

            // checking for new user

            if (query2 != null)
            {

                this.buttonAddFiles.Size = new Size(46, 37);
                this.panelFiles.Controls.Add(this.buttonAddFiles);
                this.buttonAddFiles.Location = new Point(90, 20);
                this.tabControlToShowFiles.TabPages.Remove(this.tabPageOverPanelToshowFiles);
            }

            //fillig tables
            FillDataTables();
           
            //setting location
            this.tabControlToShowFiles.Location = this.panel2.Location;
            this.panelToSetGridView.Location = this.panel2.Location;
            //this.panelTeamsHolder.Location = this.panel2.Location;

            this.tabControlToShowFiles.Size = this.panel2.Size;
            this.panelToSetGridView.Size = this.panel2.Size;
            //this.panelTeamsHolder.Size = this.panel2.Size;


            xAxix = this.panel2.Location.X;
            YAxix = this.panel2.Location.Y;
            width = this.panel2.Width;
            height = this.panel2.Height;

            this.panelFiles.Location = this.panelActivity.Location;
            this.panelSaved.Location = this.panelActivity.Location;
            this.panelTeams.Location = this.panelActivity.Location;


            //this.panelTeamsHolder.Visible = false;
            this.tabControlToShowFiles.Visible = false;
            this.panelToSetGridView.Visible = false;

            this.tabControlToShowFiles.Location = new Point(this.xAxix, this.YAxix);
            this.tabControlToShowFiles.Size = new Size(this.width, this.height);

            CloseOtherPanels();

            this.contextMenuStripFilesOption.ItemClicked += new ToolStripItemClickedEventHandler(
         contexMenuFilesOption_ItemClicked);

            this.contextMenuStripUserProfile.ItemClicked += new ToolStripItemClickedEventHandler(
                contextMenuUserProfile_ItemClicked
                );


            CloseOtherPanels();



        }

        private void dataGridViewShowTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            GuestForm Helperform = new GuestForm();
            char delemeter = Helperform.getDelimeter();
            if (delemeter != '0')
            {
               
                String filePath = "";

                // open file 
                OpenFileDialog importFile = new OpenFileDialog();
                importFile.InitialDirectory = "C://";
                importFile.Filter = "txt files (*.csv)|*.csv|All files (*.*)|*.*";
                importFile.RestoreDirectory = true;
                if (importFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        filePath = importFile.FileName;
                        dataset = new DataSet();
                        String fileName = Path.GetFileName(filePath).Trim();
                        table = new DataTable(fileName);
                        //MessageBox.Show(fileName);


                        String[] Lines = File.ReadAllLines(importFile.FileName);
                        int count = 0;
                        columns = new DataColumn[10];
                        foreach (String line in Lines)
                        {
                            fields = line.Split(delemeter);

                            if (count > 0)
                            {
                                DataRow row = table.NewRow();

                                for (int i = 0; i < fields.Length; i++)
                                {
                                    row[columns[i].ColumnName] = fields[i];
                                    //    MessageBox.Show(fields[i]);
                                }

                                table.Rows.Add(row);

                            }
                            else
                            {
                                columns = new DataColumn[fields.Length];

                                // allow user to select datatype for columns

                                for (int i = 0; i < fields.Length; i++)
                                {

                                    columns[i] = new DataColumn(fields[i], typeof(String));
                                    table.Columns.Add(columns[i]);


                                }

                            }

                            count++;
                        }
                        dataset.Tables.Add(table);
                        
                        
                        callShowNewFile(table.TableName, table);
                        //callTabHandler(table.TableName, table);



                    }
                    catch (Exception ae)
                    {

                        FileProcessorMessageBoxForm.Show(ae.Message);
                        FileProcessorMessageBoxForm.ShowDialog();
                    }
                }

            }
        }

        private void callTabHandler(String fileName, DataTable table)
        {
            this.closeCenterPanels();
            this.tabControlToShowFiles.Visible = true;
            int nextTab = this.tabControlToShowFiles.TabPages.Count;
            //MessageBox.Show("" + nextTab);
            TabPage newTabPage = new TabPage();
            newTabPage.Name = fileName;
            newTabPage.Text = fileName;
            DataGridView newGridView = new DataGridView();

            newGridView.Size = this.panelFilesHolder.Size;
            newGridView.Location = this.panelFilesHolder.Location;
            newGridView.Name = fileName;

            //newGridView.Size = new Size(this.width, this.height);
            //newGridView.Location = new Point(this.xAxix, this.YAxix);

            newGridView.DataSource = table;
            newTabPage.Controls.Add(newGridView);
            Button newCloseButton = new Button();

            newCloseButton.Location = this.btnTabClose.Location;
            newCloseButton.Text = this.btnTabClose.Text;
            newCloseButton.Font = this.btnTabClose.Font;
            newCloseButton.FlatStyle = this.btnTabClose.FlatStyle;
            newCloseButton.Size = this.btnTabClose.Size;
            newCloseButton.FlatAppearance.BorderSize = this.btnTabClose.FlatAppearance.BorderSize;
            newCloseButton.Click += btnTabClose_Click;

            this.CloseTabButtonList.Add(newCloseButton);

            newTabPage.Controls.Add(newCloseButton);
            btnTabClose.Location = new Point(newGridView.Location.X + newGridView.Width - 50, newGridView.Location.Y - 30);
            this.tabControlToShowFiles.TabPages.Add(newTabPage);

            // this.tabControlToShowFiles.Location = this.tabControlToShowFiles.Location;
            //this.tabControlToShowFiles.Size = this.tabControlToShowFiles.Size;
            this.tabControlToShowFiles.Visible = true;
            this.tabControlToShowFiles.SelectedTab = newTabPage;
            this.DataGridViewCollection.Add(newGridView);
        }
        private void buttonAddTeamMember_Click(object sender, EventArgs e)
        {

        }

        private void panelToSetGridView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TeamtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherPanels();
            this.panelTeams.Visible = true;


            closeCenterPanels();
           // this.panelTeamsHolder.Visible = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherPanels();
            this.panelActivity.Visible = true;

            closeCenterPanels();
            this.panel2.Visible = true;



        }

        private void listBoxFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {


            // show data in gridview here   

        }

        private void panelFiles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxTeamMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelTeams_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxSaved_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelSaved_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelActivity_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxFilesList_MouseClick(object sender, MouseEventArgs e)
        {

            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void listBoxFilesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bool isOpen = false;

            foreach (TabPage tab in this.tabControlToShowFiles.TabPages) {

                if (this.listBoxFilesList.SelectedItem.ToString().Trim() == tab.Name) {

                    this.tabControlToShowFiles.SelectedTab = tab;
                    isOpen = true;
                    break;
                }
            
            }
            if (!isOpen)
            {

                foreach (var t in this.tables)
                {

                    if (t.TableName == this.listBoxFilesList.SelectedItem.ToString().Trim())
                    {

                        callTabHandler(this.listBoxFilesList.SelectedItem.ToString().Trim(), this.tables[this.tables.IndexOf(t)]);
                        break;
                    }

                }
            }

        //open file on double click from database
        /*bool find = false;
        foreach (var t in this.tables) {

            if (t.TableName == this.listBoxFilesList.SelectedItem.ToString()) {
                find = true;
            }
        }
        if (!find && this.listBoxFilesList.SelectedIndex >=0 )
        {
            connectionString = ConfigurationManager.ConnectionStrings["CString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            String query = "SELECT * FROM " + this.listBoxFilesList.SelectedItem.ToString()+user.Id + "";
            command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.TableName = this.listBoxFilesList.SelectedItem.ToString();
            table.Load(reader);
            this.tables.Add(table);
            callTabHandler(this.listBoxFilesList.SelectedItem.ToString(), this.tables[this.tables.IndexOf(table)]);
        }
        */
           
        }
        
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void listBoxFilesList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStripFilesOption.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void contextMenuStripFilesOption_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

         //   ContextMenuStrip clickedItem = (ContextMenuStrip)sender;
        }

       private void deleteSelectedFile() {

            UserChoice UserChoiceform = new UserChoice("" + this.listBoxFilesList.SelectedItem.ToString());
            if (UserChoiceform.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    connection = new SqlConnection();
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["CString"].ConnectionString;
                    String query = "Drop Table " + this.listBoxFilesList.SelectedItem.ToString() + user.Id;
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    query = "delete from UserFile where userid ='" + user.Id + "' and tablename ='" + this.listBoxFilesList.SelectedItem.ToString() + "'";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand();

                    //delete file name from list box and file from datatables collection as well.

                    foreach (var t in this.tables)
                    {
                        if (t.TableName == this.listBoxFilesList.SelectedItem.ToString())
                        {
                            this.tables.Remove(t);
                            
                            break;
                        }
                    }

                    //remove tab and grid view if file is open in any tab
                    foreach (var v in this.DataGridViewCollection)
                    {
                       
                        if (v.Name == this.listBoxFilesList.SelectedItem.ToString())
                        {

                            this.DataGridViewCollection.Remove(v);

                            break;
                        }
                    }

                    
                    foreach (TabPage tab in this.tabControlToShowFiles.TabPages)
                    { 

                        if (tab.Name == this.listBoxFilesList.SelectedItem.ToString())
                        {

                            this.tabControlToShowFiles.TabPages.Remove(tab);
                            

                        }
                    }

                    this.listBoxFilesList.Items.Remove(this.listBoxFilesList.SelectedItem.ToString());


                   

                }
                catch (SqlException sqlex)
                {
                    FileProcessorMessageBoxForm.Show(sqlex.Message);
                    FileProcessorMessageBoxForm.ShowDialog();
                }


            }



        }
        void contexMenuFilesOption_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            ToolStripItem item = e.ClickedItem;
            switch (item.Text) {
                case "Edit":
                    if (this.listBoxFilesList.SelectedIndex >= 0)
                    {
                       
                        closeCenterPanels();
                        this.panelToSetGridView.Visible = true;
                        foreach (var t in this.tables)
                        {
                            if (t.TableName == this.listBoxFilesList.SelectedItem.ToString())
                            {
                                String tableName = t.TableName + user.Id;
                                ProcessFile processFile = new ProcessFile(tableName, t);
                                processFile.ShowDialog();

                                //Renew all tables of user
                                this.tables.Clear();
                                this.DataGridViewCollection.Clear();
                                this.tabControlToShowFiles.TabPages.Clear();

                                FillDataTables();


                                break;
                            }
                        }
                    }



                    // show data here.------------------------------------------------------------------------------------show data-----------------------------------------------
                    //-----------------------------------------------------------------------------------------------------------------------------------------------------------
                    break;
                case "Delete":

                    deleteSelectedFile();

                    break;
                

            
            
            }
        }
        void contextMenuUserProfile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            switch (item.Text)
            {
                case "Profile":
                    profile = new UserProfile(user);
                    profile.Show();

                
                    
                    
                    break;
               
                case "Log out": this.Dispose(); break;
                



            }
        }

        private void listBoxTeamMembers_MouseDown(object sender, MouseEventArgs e)
        {

        }

        

        private void btnFileProcessOptions_Click(object sender, EventArgs e)
        {
            this.contextMenuStripFileProcessOption.Show(Cursor.Position);
        }

        private void btnTabClose_Click(object sender, EventArgs e)
        {
            string tablename = this.tabControlToShowFiles.SelectedTab.Name;


            
           
            this.tabControlToShowFiles.TabPages.Remove(this.tabControlToShowFiles.SelectedTab);
           
            
            foreach (var v in this.DataGridViewCollection) {
                if (v.Name == tablename) {
                    this.DataGridViewCollection.Remove(v);
                    
                    break;
                }
            }

            /*foreach (var t in this.tables)
            {
                if (t.TableName.Trim().ToLower() == tablename.Trim().ToLower())
                {
                    this.tables.Remove(t);
                    
                    break;
                }
            }*/

        }
        private int xAxix, width, YAxix, height;

        private void buttonAddFileOnPanel_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------


            OpenFileDialog importFile = new OpenFileDialog();
            importFile.InitialDirectory = "C://";
            importFile.Filter = "txt files (*.csv)|*.txt|All files (*.*)|*.*";
            importFile.RestoreDirectory = true;
            if (importFile.ShowDialog() == DialogResult.OK)
                
            {
                try
                {
                    String filePath = importFile.FileName;
                    dataset = new DataSet();
                    String fileName = Path.GetFileName(filePath);
                    DataTable table = new DataTable(fileName);

                    String[] Lines = File.ReadAllLines(importFile.FileName);
                    int count = 0;
                    columns = new DataColumn[10];
                    foreach (String line in Lines)
                    {
                        String[] fields = line.Split('\t');

                        if (count > 0)
                        {
                            DataRow row = table.NewRow();

                            for (int i = 0; i < fields.Length; i++)
                            {
                                row[columns[i].ColumnName] = fields[i];

                            }

                            table.Rows.Add(row);

                        }
                        else
                        {
                            columns = new DataColumn[fields.Length];
                            for (int i = 0; i < fields.Length; i++)
                            {

                                columns[i] = new DataColumn(fields[i], typeof(String));
                                table.Columns.Add(columns[i]);
                            }

                        }

                        count++;
                    }
                    dataset.Tables.Add(table);
                    closeCenterPanels();
                    callShowNewFile(table.TableName, table);



                }
                catch (Exception ae)
                {


                }
            }
        }

        private void SetColumnName(DataColumn[] columns) {

            char[] specialCharacters =
                {' ',']','[','}','{',')','(','*','&','^','%','$','£','"','!','?','/','~','¬','`','@',':',';','<','>',',','-','+','-','\\'};
            for (int i=0;i<columns.Length;i++) {

                foreach(char c in specialCharacters)

                    columns[i].ColumnName = columns[i].ColumnName.Replace(c,'_');
            
            }
        
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------------------------------------save file-------------------------------------------


            dataTypeBox = new List<ComboBox>();
            string[] dataTpes = { "Text", "Int", "Date", "float", "char" };
            ComboBox box;
            for (int i = 0; i < columns.Length; i++)
            {
                box = new ComboBox();
                for (int j = 0; j < dataTpes.Length; j++)
                {

                    box.Items.Add(dataTpes[j]);
                }
                box.DropDownStyle = ComboBoxStyle.DropDownList;
                dataTypeBox.Add(box);
            }
            DataTypes form = new DataTypes(dataTypeBox, columns);
            String[] FieldsDatatype = new string[columns.Length];
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < form.ComboBoxes.Count; i++)
                {
                    FieldsDatatype[i] = form.ComboBoxes[i].SelectedItem.ToString();
                }
                
                String newFileName;
                InputDialog inputDialog = new InputDialog(this.user.Id);

                if (inputDialog.ShowDialog() == DialogResult.OK) {// if for input dialog

                    newFileName = inputDialog.textBoxInput.Text;

                    
                    try
                    {
                        SetColumnName(columns);
                        String query = "Create table " + newFileName + user.Id + "( id int not null identity(1,1) primary key , ";
                        for (int i = 0; i < columns.Length; i++)
                        {

                            query += columns[i] + " " + FieldsDatatype[i];
                            if (i != columns.Length - 1)
                                query += " , ";
                        }
                        query += ")";
                       // MessageBox.Show(query);

                        connectionString = ConfigurationManager.ConnectionStrings["CString"].ConnectionString;
                        connection = new SqlConnection();
                        connection.ConnectionString = connectionString;


                        command = new SqlCommand();
                        command.CommandText = query;

                        command.Connection = connection;

                        connection.Open();
                    }
                    catch (Exception ae) { 
                    
                        FileProcessorMessageBoxForm = new FileProcessorMessageBox(); 
                        FileProcessorMessageBoxForm.Show(ae.Message.ToString());
                        FileProcessorMessageBoxForm.ShowDialog(); 
                    
                    }
                    try
                    {
                        command.ExecuteNonQuery();

                        SqlBulkCopy bulk = new SqlBulkCopy(connection);
                        
                        bulk.DestinationTableName = newFileName+user.Id;
                        
                        for (int i = 0; i < columns.Length; i++) {

                           // MessageBox.Show(columns[i].ColumnName+":"+columns[i].ColumnName);

                            bulk.ColumnMappings.Add(columns[i].ColumnName, columns[i].ColumnName);

                        }
                      //  MessageBox.Show("before");
                        bulk.WriteToServer(table);
                        connection.Close();
                        //MessageBox.Show("after");
                        //adding file to userfile table after creation of table in database 
                        UserFile userFile = new UserFile();
                        userFile.UserId = user.Id;
                        userFile.TableName = newFileName;
                        dataContext.UserFiles.InsertOnSubmit(userFile);
                        dataContext.SubmitChanges();

                        //addding newly added table to list box and in tables collection 
                        this.table.TableName = newFileName;
                        this.tables.Add(this.table);
                        this.listBoxFilesList.Items.Add(newFileName);



                        checkForFirstFile();
                    }
                    catch (Exception ae) {
                        
                        FileProcessorMessageBoxForm = new FileProcessorMessageBox();
                        FileProcessorMessageBoxForm.Show(ae.Message.ToString());
                        FileProcessorMessageBoxForm.ShowDialog();


                    }


                }//end if for input dialog

            }
            

        }
        private void checkForFirstFile() {

            if (this.listBoxFilesList.Items.Count == 1) {
                this.tabPageOverPanelToshowFiles.Hide();
            }
        }

        private void btnSavedClose_Click(object sender, EventArgs e)
        {
            this.panelSaved.Visible = false;
        }

        private void btnActivityClose_Click(object sender, EventArgs e)
        {
            this.panelActivity.Visible = false;
        }

       

        private void btnTeamsClosed_Click_1(object sender, EventArgs e)
        {
            this.panelTeams.Visible = false;
        }

        private void btnSavedClose_Click_1(object sender, EventArgs e)
        {
            this.panelSaved.Visible = false;
        }

        private void btnActivityClose_Click_1(object sender, EventArgs e)
        {
            this.panelActivity.Visible = false;
        }

        private void labelFilesTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelTeamsHolder_Click(object sender, EventArgs e)
        {

        }

        private void callShowNewFile(string tableName,DataTable table) {

            closeCenterPanels();
            this.panelToSetGridView.Visible = true;
            this.dataGridViewShowNewFile.DataSource = table;
            
        
        }
        private void contextMenuStripFilesOption_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonCloseFilesPanel_Click(object sender, EventArgs e)
        {
            this.panelFiles.Visible = false;
            this.xAxix = this.panelFiles.Location.X+30;
            this.width = this.Width - this.menuMember.Width - 20;

            this.tabControlToShowFiles.Location = new Point(this.xAxix,this.YAxix);
            this.tabControlToShowFiles.Size = new Size(this.width,this.height);

            this.panelFilesHolder.Width = this.width - 10;
          

            for (int i = 0; i < this.DataGridViewCollection.Count; i++) {
                this.DataGridViewCollection[i].Width = this.panelFilesHolder.Width;
            }


        }
    }
}
