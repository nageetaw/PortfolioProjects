using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilter
{
   
    
    public partial class ProcessFile : Form
    {
        DataTable  currentTable;
        SqlCommand command;
        SqlConnection connection;
        string tableName;
        FileProcessorMessageBox fileProcessorMessageBox;
        SqlDataAdapter adapter;
        DataSet dataSet;
        bool newRow = false;
        public ProcessFile(string tableName,DataTable table)
        {
            InitializeComponent();
            this.currentTable = table;
            this.tableName = tableName;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                fileProcessorMessageBox = new FileProcessorMessageBox();
                fileProcessorMessageBox.Show("Press Ok to reflect changes");

                if (fileProcessorMessageBox.ShowDialog() == DialogResult.OK)
                {

                    DataTable dataTable = new DataTable();
                    dataTable.TableName = this.tableName;
                    dataTable = ((DataTable)this.dataGridViewFile.DataSource);
                    dataSet.Tables.RemoveAt(0);
                    dataSet.Tables.Add(dataTable);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataTable);
                }

            }
            catch (Exception ae) 
            {
                fileProcessorMessageBox = new FileProcessorMessageBox();
                fileProcessorMessageBox.Show(ae.Message);
                fileProcessorMessageBox.ShowDialog();
            }

            this.Dispose();
        }

        
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxSearch.Location = new Point(20, 73);
            this.textBoxSearch.Width += 20;

        }

        private void textBoxSearch_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void textBoxSearch_MouseEnter(object sender, EventArgs e)
        {
            //this.textBoxSearch.BackColor = Color.;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.textBoxSearch.Text == "Search...")
                this.textBoxSearch.Text = "";
            else if (this.textBoxSearch.Text == "")
            {
                this.textBoxSearch.Text = "Search...";
                
            }

        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.dataGridViewFile.ClearSelection();
            string searchedValue = this.textBoxSearch.Text.Trim().ToLower();
            try
            {
                this.dataGridViewFile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow row in this.dataGridViewFile.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Trim().Equals(searchedValue.Trim().ToLower()))
                            dataGridViewFile.Rows[row.Index].Selected = true;
                }
                
             
            }
            catch (Exception ae) {
                fileProcessorMessageBox = new FileProcessorMessageBox();
                fileProcessorMessageBox.Show(ae.Message);
                fileProcessorMessageBox.ShowDialog();
               

            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonExport_MouseHover(object sender, EventArgs e)
        {
            this.toolTiptitle.SetToolTip(this.buttonExport, "Download");
            this.contextMenuStripExportOptions.Show(this.buttonExport, new Point(11, buttonExport.Height + 10));
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            
                
            if (this.dataGridViewFile.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            fileProcessorMessageBox = new FileProcessorMessageBox();
                            fileProcessorMessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            fileProcessorMessageBox.ShowDialog();
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = this.dataGridViewFile.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[this.dataGridViewFile.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += this.dataGridViewFile.Columns[i].HeaderText.ToString() + ",";
                            }

                            outputCsv[0] += columnNames;

                            if (exportChoice)
                            {
                                for (int i = 1; i < this.dataGridViewFile.Rows.Count ; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        
                                        string Nullchecker = this.dataGridViewFile.Rows[i - 1].Cells[j].Value.ToString() + "," as string;
                                        outputCsv[i] += Nullchecker;
                                    }
                                }
                            }
                            else if(!exportChoice && this.dataGridViewFile.SelectedRows.Count>0) {
                                //MessageBox.Show(""+this.dataGridViewFile.SelectedRows.Count);
                                for (int i = 0; i < this.dataGridViewFile.SelectedRows.Count ; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        //MessageBox.Show(this.dataGridViewFile.SelectedRows[i].Cells[j].Value.ToString());
                                        string Nullchecker = this.dataGridViewFile.SelectedRows[i].Cells[j].Value.ToString() + "," as string;
                                        outputCsv[i] += Nullchecker;
                                    }
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            fileProcessorMessageBox = new FileProcessorMessageBox();
                            fileProcessorMessageBox.Show("Data Exported Successfully !!!");

                            fileProcessorMessageBox.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            fileProcessorMessageBox = new FileProcessorMessageBox();
                            fileProcessorMessageBox.Show(ex.Message);
                            fileProcessorMessageBox.ShowDialog();
                            
                        }
                    }
                }
            }
            else
            {
                fileProcessorMessageBox = new FileProcessorMessageBox();
                fileProcessorMessageBox.Show("No Record To Export !!!");
                fileProcessorMessageBox.ShowDialog();
               
            }
        }

        private void buttonSearch_MouseHover(object sender, EventArgs e)
        {
            this.toolTiptitle.SetToolTip(this.buttonSearch, "Search");
        }

        //----------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------adavanced search----------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        private void linkLabelAdvancedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdvancedSerach advancedSerach = new AdvancedSerach();

            if (advancedSerach.ShowDialog()== DialogResult.OK) {

                string[] searchAll, searchAny,searchExclude;
                string excatPharse;
                this.dataGridViewFile.ClearSelection();
                this.dataGridViewFile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                if (advancedSerach.textBoxAll.Text.Trim().Length != 0)
                {
                    
                    // perform searching here 
                    searchAll = advancedSerach.textBoxAll.Text.Trim().ToLower().Split(',');

                    
                    foreach (string keyword in searchAll) {
                    
                        string searchedValue = keyword;
                        try
                        {
                           
                            foreach (DataGridViewRow row in this.dataGridViewFile.Rows)
                            {
                                for (int i = 0; i < row.Cells.Count; i++)
                                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Trim().Equals(searchedValue))
                                        dataGridViewFile.Rows[row.Index].Selected = true;
                            }


                        }
                        catch (Exception ae)
                        {
                            fileProcessorMessageBox = new FileProcessorMessageBox();
                            fileProcessorMessageBox.Show(ae.Message);
                            fileProcessorMessageBox.ShowDialog();
                            
                        }

                    }

                }
                if (advancedSerach.textBoxAny.Text.Trim().Length != 0) {

                   
                    searchAny = advancedSerach.textBoxAny.Text.Trim().ToLower().Split(',');

                    foreach (string keyword in searchAny)
                    {

                        string searchedValue = keyword;
                        try
                        {

                            foreach (DataGridViewRow row in this.dataGridViewFile.Rows)
                            {
                                for (int i = 0; i < row.Cells.Count; i++)
                                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Trim().Equals(searchedValue))
                                        dataGridViewFile.Rows[row.Index].Selected = true;
                            }


                        }
                        catch (Exception ae)
                        {
                            fileProcessorMessageBox = new FileProcessorMessageBox();
                            fileProcessorMessageBox.Show(ae.Message);
                            fileProcessorMessageBox.ShowDialog();
                        }

                    }


                }
                if (advancedSerach.textBoxExclude.Text.Trim().Length != 0) {

                    

                    searchExclude = advancedSerach.textBoxExclude.Text.Trim().ToLower().Split(',');

                    //this.dataGridViewFile.SelectAll();

                    

                    foreach (string keyword in searchExclude)
                    {

                        string searchedValue = keyword;
                    
                        try
                        {
                            bool isMatch = false;

                           

                            foreach (DataGridViewRow row in this.dataGridViewFile.Rows)
                            {
                                isMatch = false;
                        
                                for (int i = 0; i < row.Cells.Count; i++)
                                {
                                    

                                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Trim().Equals(searchedValue))
                                    {
                                        isMatch = true;
                                       
                                        break;
                                    }
                                }
                                if (isMatch)
                                {
                                   
                                    dataGridViewFile.Rows[row.Index].Selected = false;
                                }
                                
                            }


                        }
                        catch (Exception ae)
                        {
                            fileProcessorMessageBox = new FileProcessorMessageBox();
                            fileProcessorMessageBox.Show(ae.Message);
                            fileProcessorMessageBox.ShowDialog();
                        }

                    }

                }
                if (advancedSerach.textBoxExact.Text.Trim().Length != 0) {
                   
                    // case sensitive
                  

                    excatPharse = advancedSerach.Text.Trim();
                    

                        string searchedValue =excatPharse;
                        try
                        {

                            foreach (DataGridViewRow row in this.dataGridViewFile.Rows)
                            {
                                for (int i = 0; i < row.Cells.Count; i++)
                                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Trim().Equals(searchedValue))
                                        dataGridViewFile.Rows[row.Index].Selected = true;
                            }


                        }
                        catch (Exception ae)
                        {
                        fileProcessorMessageBox = new FileProcessorMessageBox();
                        fileProcessorMessageBox.Show(ae.Message);
                        fileProcessorMessageBox.ShowDialog();
                    }

                }

            }
        }

        private void contextMenuStripSelectedRow_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            List<DataGridViewRow> deletedRow= new List<DataGridViewRow>();


            try
            {
                
                if (e.ClickedItem.Text == "Delete")
                {
                    foreach (DataGridViewRow row in dataGridViewFile.SelectedRows)
                    {

                        this.dataGridViewFile.Rows.Remove(row);
                    }
                }
                else if (e.ClickedItem.Text == "Edit")
                {

                    for (int i = 0; i < this.dataGridViewFile.SelectedRows.Count; i++)
                    {
                        this.dataGridViewFile.SelectedRows[i].ReadOnly = false;
                        this.dataGridViewFile.SelectedRows[i].DefaultCellStyle.SelectionBackColor = Color.Gray;
                    }
                }
                else if (e.ClickedItem.Text == "Add Row") {
                    
                    newRow = true;
                    this.dataGridViewFile.ClearSelection();
                    this.dataGridViewFile.Rows[this.dataGridViewFile.RowCount-1].Selected = true;
                    this.dataGridViewFile.CurrentCell = this.dataGridViewFile.SelectedRows[0].Cells[0];

                }
            }
            catch (Exception ae) {
                MessageBox.Show(ae.Message);
            }

        }
        // need to change context menu
        private void dataGridViewFile_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.contextMenuStripSelectedRow.Show(Cursor.Position);
        }

        private void dataGridViewFile_SelectionChanged(object sender, EventArgs e)
        {
            
           /* for (int i = 0; i < this.dataGridViewFile.SelectedRows.Count; i++) {
                this.dataGridViewFile.FirstDisplayedScrollingRowIndex = dataGridViewFile.SelectedRows[i].Index;
            }*/
        }

        private void dataGridViewFile_Click(object sender, EventArgs e)
        {
            
                
        }

        private void dataGridViewFile_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                if (this.dataGridViewFile.SelectedRows.Count > 0)
                    this.contextMenuStripSelectedRow.Show(Cursor.Position);
                else
                    this.contextMenuStripBasicOptions.Show(Cursor.Position);
            
            }

        }

        

        private void dataGridViewFile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void contextMenuStripBasicOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            newRow = true;
            this.dataGridViewFile.ClearSelection();
            this.dataGridViewFile.Rows[this.dataGridViewFile.RowCount - 1].Selected = true;
            this.dataGridViewFile.CurrentCell = this.dataGridViewFile.SelectedRows[0].Cells[0];
        }

        private void dataGridViewFile_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            DataRow dr = this.currentTable.NewRow();
            DataGridViewRow NewRow = (DataGridViewRow)this.dataGridViewFile.CurrentRow.Clone();
            for (int i = 0; i < this.dataGridViewFile.ColumnCount; i++)
            {
                dr[i] = NewRow.Cells[0].Clone();
            }
            

           this.dataGridViewFile.Rows.Add(NewRow);
            this.currentTable.Rows.Add(dr);
           
        }
       
        private void dataGridViewFile_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
          /* try
            {
                if (newRow)
                {
                   
                    DataRow dataRow=this.currentTable.NewRow();
                    MessageBox.Show("new romvnf");
                    for (int i = 0; i < this.dataGridViewFile.Columns.Count;i++) {

                        dataRow[i] = Convert.ChangeType(  this.dataGridViewFile.Rows[e.RowIndex].Cells[i],this.currentTable.Columns[i].DataType);
                    }


                   /* DataGridViewRow newRow = this.dataGridViewFile.Rows[e.RowIndex];
                    //this.dataGridViewFile.Rows.Add(newRow);

                    DataRow row = this.dataSet.Tables[0].NewRow();
                    row = ((DataRowView)this.dataGridViewFile.Rows[e.RowIndex].DataBoundItem).Row;
                    this.dataSet.Tables[0].Rows.Add(dataRow);

                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                    sqlCommandBuilder.GetUpdateCommand();

                    adapter.Update(this.dataSet, this.tableName);

            

                }
            }
            catch (Exception ae) { MessageBox.Show(ae.Message); }*/
        }

        private void ProcessFile_Load(object sender, EventArgs e)
        {
            exportChoice = true;
            fileProcessorMessageBox = new FileProcessorMessageBox();
            newRow = false;
            try
            {
                connection = new SqlConnection();

                connection.ConnectionString = ConfigurationManager.ConnectionStrings["CString"].ConnectionString;

                string selllectAll = "Select * from " +this.tableName + ";";
                
                command = new SqlCommand(selllectAll, connection);
                connection.Open();
                adapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet,this.tableName);
               
                this.dataGridViewFile.DataSource = dataSet.Tables[this.tableName];
                
                connection.Close();
               
            }
            catch (Exception ae) {
                fileProcessorMessageBox = new FileProcessorMessageBox();
                fileProcessorMessageBox.Show(ae.Message);
                fileProcessorMessageBox.ShowDialog();
                this.Dispose();
            }
        }
        // true to export all
        // false to export selected
        // by default it is true.
        bool exportChoice;
        private void contextMenuStripExportOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Export All"))
                exportChoice = true;
            else exportChoice = false;
        }

        private void buttonExport_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
