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
    public partial class FileProcessorMessageBox : Form
    {
        public FileProcessorMessageBox()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
        internal void Show(String message) {
            this.labelGernalMessage.Text = message;
        
        }

        private void FileProcessorMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
