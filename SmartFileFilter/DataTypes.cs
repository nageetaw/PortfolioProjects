using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilter
{
    public partial class DataTypes : Form
    {
        DataColumn[] Tempfields;
        public List<ComboBox> ComboBoxes;
        Label[] labels;
        public DataTypes(List<ComboBox> comboBoxes,DataColumn[] fields)
        {
            InitializeComponent();
            //comboBoxes = new List<ComboBox>();
            
            this.ComboBoxes = comboBoxes;
            this.Tempfields = fields;
            labels = new Label[fields.Length];
           
            
        }
       
        private void DataTypes_Load(object sender, EventArgs e)
        {
            int y = 20;
            for (int i = 0; i < Tempfields.Length; i++) {

                this.labels[i] = new Label();
                this.labels[i].Text = this.Tempfields[i].ColumnName;
                this.labels[i].Location= new Point(20, y); 
                this.labels[i].Size = new Size(150, 30);
                this.ComboBoxes[i].Location = new Point(160, y); y += 35;
                this.ComboBoxes[i].Size = new Size(100, 30);
                this.Controls.Add(ComboBoxes[i]);
                this.Controls.Add(this.labels[i]);
              
            }
            this.buttonNext.Location = new Point(this.buttonNext.Location.X,y);
           
        }

        FileProcessorMessageBox fileProcessorMessageBox;
        private void buttonNext_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < this.ComboBoxes.Count; i++) {
                if (this.ComboBoxes[i].SelectedIndex > -1)
                {

                }
                else {
                    flag = false;
                }
            }
            if (flag)
            {
                this.buttonNext.DialogResult = DialogResult.OK;
            }
            else {
                fileProcessorMessageBox = new FileProcessorMessageBox();
                fileProcessorMessageBox.Show("Please fill complete boxes");
                fileProcessorMessageBox.ShowDialog();
                
            }
        }

    }
}
