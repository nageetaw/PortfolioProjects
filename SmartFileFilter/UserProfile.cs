using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilter
{
    public partial class UserProfile : Form
    {
        linqtosqlDataContext context;
        User user;
        public UserProfile(User  user)
        {
            InitializeComponent();
            this.user = user;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxUserProfile_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void pictureBoxUserProfile_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            this.labelUserName.Text = user.FirstName.Trim()+" "+user.LastName.Trim();
            this.labelAccountType.Text = user.AccountType.Trim();
            this.labelDob.Text = user.DateOfBirth.Trim();
            this.textBoxEmail.Text = user.EmailAddress.Trim();
            this.labelUserId.Text = user.Id;
            this.labelEmail.Text= user.EmailAddress.Trim();
            DateTime dateTime = DateTime.UtcNow.Date;
            
            String year = dateTime.ToString("yyyy");
            int startYear = Convert.ToInt32(year) - 100;
            int endYear = Convert.ToInt32(year);
            for (int i = endYear; i >= startYear; i--)
            {

                this.comboBoxYear.Items.Add("" + i);
            }
            for (int i = 1; i <= 31; i++) this.comboBoxDay.Items.Add("" + i);

            if (user.ProfilePicture == null) {
                if (user.Gender.Trim().ToLower() == "male")
                {
                    this.pictureBoxUserProfile.BackgroundImage = Image.FromFile(@"C:\Users\nigit\source\repos\DataFilter\male.png");

                }
                else {
                    this.pictureBoxUserProfile.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\female.png");

                }
            } else
                this.pictureBoxUserProfile.BackgroundImage = Image.FromFile(user.ProfilePicture);
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.labelDob.Visible = false;
            this.textBoxEmail.Enabled = true;
            this.buttonUpload.Visible = true;
            this.comboBoxDay.Visible = true;
            this.comboBoxMonth.Visible = true;
            this.comboBoxYear.Visible = true;
            this.btnSaveChanges.Visible = true;
            this.textBoxEmail.Visible = true;
            this.btnEdit.Visible = false;
            this.labelEmail.Visible = false;
            
           
        }

        private bool validateData() {
            bool isDOBValid = false, isEmailValid=false;
            if (this.comboBoxMonth.Text.ToString().ToLower() == "month" || this.comboBoxDay.Text.ToString().ToLower() == "day" || this.comboBoxYear.Text.ToString().ToLower() == "year")
            {

                errorProviderbirthdate.SetError(this.comboBoxDay, "Please select date");
            }
            else
            {
                errorProviderbirthdate.Clear();

                int month = getMonth();
                String date = this.comboBoxDay.Text.ToString() + "/" + month + "/" + this.comboBoxYear.Text.ToString();
                DateTime dt;

                bool Valid = DateTime.TryParseExact(date, "d/M/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
                if (!Valid)
                {
                    errorProviderbirthdate.SetError(this.comboBoxDay, "Date is not valid");
                }
                else
                {
                    isDOBValid = true;
                    errorProviderbirthdate.Clear();
                }
            }
            Regex nameexp = new Regex(@"^[a-zA-Z\s]+$");

            Regex emailexp = new Regex(@"^[a-zA-Z0-9]+[_.-]*[a-zA-Z0-9]+@[a-zA-Z]+(.com)$");

            if (this.textBoxEmail.Text.Trim().Length == 0)
            {

                errorProviderEmail.SetError(this.textBoxEmail, "plesae Enter email address");
            }
            else
            {
                errorProviderEmail.Clear();

                if (!emailexp.IsMatch(this.textBoxEmail.Text.Trim()))
                {

                    errorProviderEmail.SetError(this.textBoxEmail, "Email address is not valid");
                }
                else
                {
                    isEmailValid = true;
                    errorProviderEmail.Clear();
                }
            }
            if(isDOBValid && isEmailValid)
            {
                return true;
            }else
            return false;
        }
        int getMonth()
        {

            int month = 0;
            string m = this.comboBoxMonth.Text.ToLower();
            switch (m)
            {

                case "jan": month = 1; break;
                case "feb": month = 2; break;
                case "march": month = 3; break;
                case "april": month = 4; break;
                case "may": month = 5; break;
                case "june": month = 6; break;
                case "july": month = 7; break;
                case "aug": month = 8; break;
                case "sep": month = 9; break;
                case "oct": month = 10; break;
                case "nov": month = 11; break;
                case "dec": month = 12; break;

            }
            return month;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // first validate new values and then sumbit changes using datacontext.

            if (validateData())
            {
                try
                {
                    int month = getMonth();
                    String date = this.comboBoxDay.Text.ToString() + "/" + month + "/" + this.comboBoxYear.Text.ToString();

                    context = new linqtosqlDataContext();
                  
                    User user = context.Users.SingleOrDefault(u => u.Id == this.user.Id);
                    
                    user.DateOfBirth = date;
                    user.EmailAddress = this.textBoxEmail.Text.Trim();
                    
                    user.ProfilePicture = filepath;

                    // updating user data
                    context.SubmitChanges();


                    //setting visibility
                    this.comboBoxMonth.Visible = false;
                    this.comboBoxYear.Visible = false;
                    this.comboBoxDay.Visible = false;
                    this.labelDob.Text = user.DateOfBirth;
                    this.labelDob.Visible = true;
                    this.buttonUpload.Visible = false;
                    this.textBoxEmail.Text = user.EmailAddress;
                    this.labelEmail.Text = user.EmailAddress;
                    this.labelEmail.Visible = true;
                    this.textBoxEmail.Enabled = false;
                    this.btnSaveChanges.Visible = false;
                    this.btnEdit.Visible = true;
                    this.textBoxEmail.Visible = false;
                    
                }
                catch (Exception ae) {


                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show(ae.Message);
                    fileProcessorMessageBox.ShowDialog();

                }
            }


        }
        FileProcessorMessageBox fileProcessorMessageBox;
        private void linkLabelChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword ForgetPasswordform = new ForgetPassword(this.user);
            ForgetPasswordform.ShowDialog();
            this.Dispose();
        }

        private void labelUserId_MouseHover(object sender, EventArgs e)
        {
            this.toolTiptip.SetToolTip(this.labelUserId, "User Id");
        }

        private void labelAccountType_MouseHover(object sender, EventArgs e)
        {
            this.toolTiptip.SetToolTip(this.labelAccountType, "Account type");
        }

        private void labelUserName_MouseHover(object sender, EventArgs e)
        {
            this.toolTiptip.SetToolTip(this.labelUserName, "Name");
        }

        private void textBoxDOB_MouseHover(object sender, EventArgs e)
        {
            this.toolTiptip.SetToolTip(this.labelDob, "Date of birth");
        }

        private void textBoxEmail_MouseHover(object sender, EventArgs e)
        {
            this.toolTiptip.SetToolTip(this.labelEmail, "Email Id");
        }
        string filepath;
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            
            if (this.openFileDialogUpload.ShowDialog() == DialogResult.OK) {

                filepath = this.openFileDialogUpload.FileName;
                this.pictureBoxUserProfile.BackgroundImage = Image.FromFile(filepath);
            }


            

        }
    }
}
