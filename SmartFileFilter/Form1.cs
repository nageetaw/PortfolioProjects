using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Text.RegularExpressions;

namespace DataFilter
{
    public partial class MainPage : Form
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        bool HideOrShow;
        private void MainPage_Load(object sender, EventArgs e)
        {
            HideOrShow = true;
            this.btnShowOrHide.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
            this.btnShowOrHide.BackgroundImageLayout = ImageLayout.Zoom;
          
            this.panelGuest.Location = this.panelMember.Location;
            this.panelGuest.Visible=false;
            this.panelMember.Visible=false;
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (!HideOrShow)
            {
                this.btnShowOrHide.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
                this.btnShowOrHide.BackgroundImageLayout = ImageLayout.Zoom;
                HideOrShow = !HideOrShow;
                this.textUserPassword.PasswordChar = '*';
            }
            else
            {
                this.btnShowOrHide.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\show.png");
                this.btnShowOrHide.BackgroundImageLayout = ImageLayout.Zoom; HideOrShow = !HideOrShow;
                this.textUserPassword.PasswordChar = '\0';
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textUserId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void closeAllPanels() {
            this.panelGuest.Visible = false;
            this.panelMember.Visible = false;
        }
        private void btnAsGuest_Click(object sender, EventArgs e)
        {

            closeAllPanels();
            this.panelGuest.Visible = true;
           

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            closeAllPanels();
            this.panelMember.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            closeAllPanels();

        }

        private void btnUserBack_Click(object sender, EventArgs e)
        {

            closeAllPanels();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStartTrial_Click(object sender, EventArgs e)
        {
            Regex nameexp = new Regex(@"^[a-zA-Z\s]+$");

            this.errorProviderUserId.Clear();
            if (this.textGuestName.Text.Trim().Length == 0)
            {
                this.errorProviderUserId.SetError(this.textGuestName, "Please Enter your name");
            }
            else if (!nameexp.IsMatch(this.textGuestName.Text))
            {

                this.errorProviderUserId.SetError(this.textGuestName, "Please Enter a valid Name");

            }
            else {

               GuestForm guestForm = new GuestForm(this.textGuestName.Text);
                this.Hide();
                guestForm.ShowDialog();
                this.Show();
            }
            
        }
        linqtosqlDataContext datacontext;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            datacontext = new linqtosqlDataContext();
            errorProviderUserId.Clear();
            errorProviderUserPassword.Clear();
            if (this.textUserId.Text.Trim().Length == 0)
            {

                this.errorProviderUserId.SetError(this.textUserId, "Please enter user id");
            }
            
            if (this.textUserPassword.Text.Trim().Length == 0)
            {
                this.errorProviderUserPassword.SetError(this.textUserPassword, "Please enter password");

            }

            if (this.textUserPassword.Text.Trim().Length > 0 && this.textUserId.Text.Trim().Length > 0)
            {

                try
                {
                    User user = datacontext.Users.SingleOrDefault(record => record.Id == this.textUserId.Text);
                    if (user == null)
                    {

                        errorProviderUserId.SetError(this.textUserId, "User not found");

                    }
                    else
                    {
                        if (user.NewPassword.Trim() == this.textUserPassword.Text.Trim())
                        {
                            Member MemberForm = new Member(user);
                            this.Hide();
                            MemberForm.ShowDialog();
                            if (!this.checkBoxRememberMe.Checked)
                            {
                                this.textUserId.Text = "";
                                this.textUserPassword.Text = "";
                            }
                            this.Show();
                        }
                        else
                            errorProviderUserPassword.SetError(this.textUserPassword, "Incorrect password");
                    }
                }
                catch (Exception ne)
                {
                    errorProviderUserId.SetError(this.textUserId, ne.Message);
                }

            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            this.Hide();
            signupForm.ShowDialog();
            this.Show();
        }

        private void btnShowOrHide_Click(object sender, EventArgs e)
        {

        }

        private void textGuestName_MouseUp(object sender, MouseEventArgs e)
        {
            this.toolTipTitle.SetToolTip(this.textGuestName, "Enter user name");
        }

        private void textUserId_MouseUp(object sender, MouseEventArgs e)
        {
            this.toolTipTitle.SetToolTip(this.textUserId, "Enter user id");
        }

        private void textUserPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.toolTipTitle.SetToolTip(this.textUserPassword, "Enter password");
        }

        
        private void btnUserPanelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.toolTipTitle.SetToolTip(this.btnUserPanelTitle, "File Processor");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword ForgetPasswordForm = new ForgetPassword();
            this.Hide();
            ForgetPasswordForm.ShowDialog();
            this.Show();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            this.Hide();
            AboutForm.ShowDialog();
            this.Show();
        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            this.toolTipTitle.SetToolTip(this.btnAbout, "Want to know About Us ?");
        }
    }
}
