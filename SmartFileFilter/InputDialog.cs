using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DataFilter
{
 
    public partial class InputDialog : Form
    {
        String userId;
        private linqtosqlDataContext context;
        public InputDialog(String userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        FileProcessorMessageBox fileProcessorMessageBox;
        private void btnOk_Click(object sender, EventArgs e)
        {

           
            if (this.textBoxInput.Text.Trim().Length == 0)
            {
                this.errorProviderFileName.SetError(this.textBoxInput, "Enter file name");
            }
            else {
             

                //UserFile userFiledata = context.UserFiles.SingleOrDefault(record => record.UserId == this.userId && record.TableName == this.textBoxInput.Text);
                int count = 0;
                string tablename = this.textBoxInput.Text;
                try
                {
                    count = (from row in context.UserFiles where row.UserId.ToString() == this.userId && row.TableName.ToString() == tablename select row).Count();
                }
                catch (Exception ae) {
                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show(ae.Message);
                    fileProcessorMessageBox.ShowDialog();
                  
                }
                if (count > 0)
                {

                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show("file name already exists");
                    fileProcessorMessageBox.ShowDialog();
                    

                }
                else
                {
                   this.btnOk.DialogResult = DialogResult.OK;
                
                }
               

            }
        }
        
        private void InputDialog_Load(object sender, EventArgs e)
        {
            context = new linqtosqlDataContext();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
