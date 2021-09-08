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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayerIntroduction_Enter(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayerIntroduction_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (this.axWindowsMediaPlayerIntroduction.playState == WMPLib.WMPPlayState.wmppsStopped)
                this.Dispose();
              
        }
    }
}
