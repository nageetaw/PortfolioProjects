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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            this.circularProgressBarLoading.Value = 0;
            this.circularProgressBarLoading.Maximum = 100;
            this.circularProgressBarLoading.Minimum = 0;
            value = 40;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            
        }
        internal int value;
        internal void ResetBarValue() {

            this.circularProgressBarLoading.Value = 50;
            this.value = 90;
        }
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (this.circularProgressBarLoading.Value <= value)
            {
                this.circularProgressBarLoading.Value += 10;
            }
            else {
                this.timerLoad.Enabled = false;
                this.Dispose();
            }
        }
       
    }
}
