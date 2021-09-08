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
    public partial class SecurityCheck : Form
    {
       
        public SecurityCheck()
        {
            InitializeComponent();
        }

        private void SecurityCheck_Load(object sender, EventArgs e)
        {
            this.comboBoxSecurtyQues.Text = "Please select a question";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.errorProviderSecurityAnswer.Clear();
            this.errorProviderSecurityQuestion.Clear();
            
            if (this.comboBoxSecurtyQues.SelectedIndex < 0)
            {

                this.errorProviderSecurityQuestion.SetError(this.comboBoxSecurtyQues, "Please select a question");
            }
            else
            {
                this.textBoxSecurityAns.Visible = true;
                if (this.textBoxSecurityAns.Text.Trim().Length == 0)
                {
                    this.errorProviderSecurityAnswer.SetError(this.textBoxSecurityAns, "Please write your answer");

                }
                else
                {
                    if (this.textBoxSecurityAns.Text.Trim().Length < 3 || this.textBoxSecurityAns.Text.Trim().Length > 50)
                    {
                        this.errorProviderSecurityAnswer.SetError(this.textBoxSecurityAns, "Answer should be between 3 to 50 characters");
                    }
                    else
                    {
                        
                        SignUp parent = (SignUp)this.Owner;
                        parent.SetSecurityQuestionValues(this.comboBoxSecurtyQues.SelectedIndex + 1, this.textBoxSecurityAns.Text);
                        this.Dispose();
                        // store results to database first then
                        // call member form here
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SecurityCheck_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSecurtyQues_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxSecurityAns.Visible = true;
        }
    }
}
