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
    public partial class RedirectForm : Form
    {
        int i;
        public RedirectForm()
        {
            InitializeComponent();
        }

        private void RedirectForm_Load(object sender, EventArgs e)
        {
            i = 0;       }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (i <= 30) i += 10;
            else {
                this.timer1.Enabled = false;
                this.Dispose();
            }
        }
    }
}
