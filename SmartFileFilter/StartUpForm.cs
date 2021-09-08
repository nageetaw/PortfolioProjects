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

    public partial class StartUpForm : Form
    {
        int Value;
        public StartUpForm()
        {
            InitializeComponent();

        }

        private void StartUpForm_Load(object sender, EventArgs e)
        {
            Value = 0; flag = false;
        }
        bool flag;
        private void timerStartUp_Tick(object sender, EventArgs e)
        {
            if (this.Value <= 90)
            {

                this.Value += 10;
                if (!flag)
                {
                    this.btnOne.Show();
                    this.btnTwo.Show();
                    this.btnThree.Hide(); this.btnFour.Hide(); this.btnFive.Hide();this.btnSix.Hide();
                    
                    flag = !flag;
                }
                else
                {
                    this.btnFive.Show();
                    this.btnThree.Show();
                    this.btnOne.Hide(); this.btnTwo.Hide(); this.btnFour.Hide(); this.btnFive.Hide();this.btnSix.Hide();
                    
                }

            }
            else
            {
                this.timerStartUp.Enabled = false;
                this.Hide();
                MainPage form = new MainPage();
                form.ShowDialog(); this.Dispose();

            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {

        }

        private void timerTwo_Tick(object sender, EventArgs e)
        {
            if (this.Value <= 90)
            {
                
                this.Value += 10;
                if (!flag)
                {
                    this.btnThree.Show();
                    this.btnFour.Show();
                    this.btnOne.Hide();
                    this.btnTwo.Hide();
                    this.btnFive.Hide();
                    this.btnSix.Hide();

                }
                else
                {
                    this.btnSix.Show();
                    this.btnFive.Show();
                    this.btnOne.Hide(); this.btnTwo.Hide();this.btnThree.Hide(); this.btnFour.Hide();
                    flag = !flag;
                }

            }
            else
            {
                this.timerTwo.Enabled = false;
            }
        }
    }
}
