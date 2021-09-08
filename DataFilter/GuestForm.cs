using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilter
{
    public partial class GuestForm : Form
    {
        String guestName;
        DataSet dataset;
        DataTable datatable;
        DataColumn[] columns;
        DataRow rows;
        public GuestForm() {
            InitializeComponent();
        }
        public GuestForm(String guestName)
        {
            InitializeComponent();
            this.guestName = guestName;
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            this.labelGuestName.Text = guestName;
        }

        private void buttonAddFilesGuest_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        Form Delemeterform;
        Label Delemeterformlabel;
        ComboBox DelemeterformtextBox;
        Button buttonImport;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFileProcessOptions_Click(object sender, EventArgs e)
        {
            this.contextMenuStripGuestFilesOption.Show(Cursor.Position.X, Cursor.Position.Y);
        }
        char getCharDel(string del) {
            char delimeter = '*';
            switch (del) {
                case "Space": delimeter = ' ';
                    break;
                case "Tab": delimeter = '\t';
                    break;
                case "Back Slash": delimeter = '\\';
                    break;
                case "Forward Slash": delimeter = '/';
                    break;
                case "Comma": delimeter = ',';
                    break;
                case "Colon": delimeter = ':';
                    break;
                case "Pipe": delimeter = '|';
                    break;
                case "Dollar": delimeter = '$';
                    break;
                case "Hash": delimeter = '#';
                    break;

            }
            return delimeter;
        }
        internal char getDelimeter() {

            Delemeterform = new Form();
            Delemeterformlabel = new Label();
            DelemeterformtextBox = new ComboBox();
            DelemeterformtextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DelemeterformtextBox.Items.Add("Space");
            DelemeterformtextBox.Items.Add("Tab");
            DelemeterformtextBox.Items.Add("Back Slash");
            DelemeterformtextBox.Items.Add("Forward Slash");
            DelemeterformtextBox.Items.Add("Comma");
            DelemeterformtextBox.Items.Add("Colon");
            DelemeterformtextBox.Items.Add("Pipe");
            DelemeterformtextBox.Items.Add("Dollar");
            DelemeterformtextBox.Items.Add("Hash");



            buttonImport = new Button();
            buttonImport.Text = "Ok";
            Delemeterformlabel.Text = "Select Delimeter";
            Button cancel = new Button();
            cancel.Text = "Cancel";
            cancel.DialogResult = DialogResult.Cancel;
            buttonImport.DialogResult = DialogResult.OK;
            String del;
            Delemeterformlabel.SetBounds(100, 20, 150, 13);
            DelemeterformtextBox.SetBounds(100, 36, 150, 20);
            buttonImport.SetBounds(100, 72, 70, 23);
            cancel.SetBounds(200, 72, 70, 23);

            Delemeterform.BackColor = Color.AliceBlue;
            Delemeterform.ClientSize = new Size(300, 150);
            Delemeterform.Controls.AddRange(new Control[] { Delemeterformlabel, DelemeterformtextBox, buttonImport, cancel });

            Delemeterform.FormBorderStyle = FormBorderStyle.FixedDialog;
            Delemeterform.StartPosition = FormStartPosition.CenterScreen;
            Delemeterform.MinimizeBox = false;
            Delemeterform.MaximizeBox = false;
            Delemeterform.FormBorderStyle = (FormBorderStyle)BorderStyle.None;
            Delemeterform.AcceptButton = buttonImport;
            if (Delemeterform.ShowDialog() == DialogResult.OK)
            {
                del = DelemeterformtextBox.SelectedItem.ToString();
                return getCharDel(del);
            }
            else {
                return '0';
            }


        }
        public List<ComboBox> dataTypeBox;
        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            char delemeter = getDelimeter();
            if (delemeter != '*' || delemeter != '0')
            {
                dataset = new DataSet();
                String filePath = "", fileName;
                openFileDialogGuest.Filter = "txt files (*.csv)|*.txt|All files (*.*)|*.*";
                if (this.openFileDialogGuest.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialogGuest.FileName;
                    fileName = Path.GetFileName(filePath);
                    datatable = new DataTable(fileName);

                    String[] Rows = File.ReadAllLines(filePath);
                    int count = 0;
                    foreach (var row in Rows)
                    {

                        String[] fields = row.Split(delemeter);

                        if (count > 0)
                        {
                            rows = datatable.NewRow();
                            for (int i = 0; i < fields.Length; i++)
                            {
                                rows[i] = fields[i];

                            }

                            datatable.Rows.Add(rows);
                        }
                        else
                        {
                            columns = new DataColumn[fields.Length];
                            // allow user to select datatype for columns
                            dataTypeBox = new List<ComboBox>();
                            string[] dataTpes = {"String","Int","DateTime","double","char"};
                            ComboBox box;
                            for (int i = 0; i < columns.Length; i++) {
                                box = new ComboBox();
                                for (int j = 0; j < dataTpes.Length; j++) {

                                    box.Items.Add(dataTpes[j]);
                                }
                                box.DropDownStyle = ComboBoxStyle.DropDownList;
                                dataTypeBox.Add(box);
                            }
                            DataTypes form = new DataTypes(dataTypeBox,columns);// need to modify
                            String[] FieldsDatatype = new string[columns.Length];
                            if (form.ShowDialog() == DialogResult.OK) {
                                for (int i = 0; i < form.ComboBoxes.Count; i++)
                                {
                                    FieldsDatatype[i] = form.ComboBoxes[i].SelectedItem.ToString();
                                }   
                            }
                            for (int i = 0; i < fields.Length; i++)
                            {
                                if(FieldsDatatype[i]=="String")
                                     columns[i] = new DataColumn(fields[i], typeof(String));
                                else if (FieldsDatatype[i] == "Int")
                                    columns[i] = new DataColumn(fields[i], typeof(int));
                                else if (FieldsDatatype[i] == "DateTime")
                                    columns[i] = new DataColumn(fields[i], typeof(DateTime));
                                else if (FieldsDatatype[i] == "double")
                                    columns[i] = new DataColumn(fields[i], typeof(double));
                                else if (FieldsDatatype[i] == "char")
                                    columns[i] = new DataColumn(fields[i], typeof(char));

                                this.comboBoxSelectField.Items.Add(fields[i]);
                                
                                datatable.Columns.Add(columns[i]);


                            }
                 
                        }
                        count++;

                    }
                    for (int i = 1; i <= this.datatable.Rows.Count; i++) {
                       
                    }

                    dataset.Tables.Add(datatable);
                    this.panelToSetGridViewGuest.Controls.Remove(this.btnAddFiles);
                    this.panelToSetGridViewGuest.Controls.Remove(this.lblAddFiles);
                    this.dataGridViewShowTablesGuest.DataSource = dataset.Tables[0];
                    showControlls();
                }
            }
        }
        private void showControlls() {

            this.dataGridViewShowTablesGuest.Visible = true;
            this.btnFileProcessOptions.Visible = true;
            this.labelSelectField.Visible = true;
            this.comboBoxSelectField.Visible = true;
            this.comboBoxEquality.Visible = true;
            this.buttonSearch.Visible = true;
            this.textBoxSerach.Visible = true;
            
            this.btnFileProcessOptions.Visible = true;
        }
        private void dataGridViewShowTablesGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewShowTablesGuest_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                this.contextMenuStripHeaderOptions.Show(Cursor.Position);
            }
            for (int i = 0; i < this.dataGridViewShowTablesGuest.Columns.Count; i++)
                this.dataGridViewShowTablesGuest.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dataGridViewShowTablesGuest.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            if (this.dataGridViewShowTablesGuest.Columns.Count > 0)
                dataGridViewShowTablesGuest.Columns[e.ColumnIndex].Selected = true;


        }

        private void contextMenuStripHeaderOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            switch (item.Text) {
                case "Select All":
                    if (this.dataGridViewShowTablesGuest.Columns.Count > 0)
                        for (int i = 0; i < this.dataGridViewShowTablesGuest.Columns.Count; i++)
                            dataGridViewShowTablesGuest.Columns[i].Selected = true;

                    break;

            }
        }

        private void dataGridViewShowTablesGuest_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                this.contextMenuStripHeaderOptions.Show(Cursor.Position);
            }

            this.dataGridViewShowTablesGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (this.dataGridViewShowTablesGuest.Rows.Count > 0)
                dataGridViewShowTablesGuest.Rows[e.RowIndex].Selected = true;

        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (this.textBoxSerach.Text == "Search.." || this.textBoxSerach.Text.Length == 0 || this.comboBoxSelectField.SelectedIndex < 0)
            {
               // MessageBox.Show("in if ");
            }
            else {
               // MessageBox.Show("in else");
                if (this.comboBoxEquality.SelectedIndex > -1)
                {
                    DoEqualityFilter();
                 //   MessageBox.Show("equality selected");
                }
                else {


                }
            }
        }
        private void DoEqualityFilter()
        {
            String field = this.comboBoxSelectField.SelectedItem.ToString();

            if (this.comboBoxEquality.SelectedItem.ToString() == "Equal")
            {
                var query = from row in datatable.AsEnumerable() where row.Field<String>(field) == this.textBoxSerach.Text select row;
                this.dataGridViewShowTablesGuest.DataSource = query.AsDataView();
              
               
            }
            else if (this.comboBoxEquality.SelectedItem.ToString() == "Not Equal")
            {
                var query = from row in datatable.AsEnumerable() where row.Field<String>(field) != this.textBoxSerach.Text select row;
                this.dataGridViewShowTablesGuest.DataSource = query.AsDataView();

            }
            

        }
        private void textBoxSerach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerach_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBoxSerach.Text = "";
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            this.dataGridViewShowTablesGuest.DataSource = datatable;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStripGuestFilesOption_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
