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
    public partial class UserChoice : Form
    {
        string filename;
        public UserChoice(string filename)
        {
            InitializeComponent();
            this.filename = filename;
            this.labelMessage.Text = "Delete " + filename;
        }

        private void UserChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
