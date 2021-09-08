using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilter
{
    public partial class SignUp : Form
    {
        internal linqtosqlDataContext datacontext;
        public SignUp()
        {
            InitializeComponent();
        }
        
        private void SignUp_Load(object sender, EventArgs e)
        {
            HideOrShow = true;
            this.btnShowOrHide.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
            this.btnShowOrHide.BackgroundImageLayout = ImageLayout.Zoom;
            DateTime dateTime = DateTime.UtcNow.Date;
            String year = dateTime.ToString("yyyy");
            int startYear = Convert.ToInt32(year)-100;
            int endYear = Convert.ToInt32(year);
            for (int i = endYear; i >= startYear; i--)
            {

                this.comboBoxYear.Items.Add("" + i);
            }
            for (int i = 1; i <= 31; i++) this.comboBoxDay.Items.Add("" + i);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        bool HideOrShow;

        private void btnShowOrHide_Click(object sender, EventArgs e)
        {
            if (!HideOrShow)
            {
                this.btnShowOrHide.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
                this.btnShowOrHide.BackgroundImageLayout = ImageLayout.Zoom; 
                HideOrShow = !HideOrShow;
                this.textBoxPassword.PasswordChar = '*';
            }
            else {
                this.btnShowOrHide.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\show.png");
                this.btnShowOrHide.BackgroundImageLayout = ImageLayout.Zoom; HideOrShow = !HideOrShow;
                this.textBoxPassword.PasswordChar = '\0';
            }
        }
        private void clearAllErrors() {
            this.errorProviderAccountType.Clear();
            this.errorProviderbirthdate.Clear();
            this.errorProviderEmail.Clear();
            this.errorProviderFirstName.Clear();
            this.errorProviderGender.Clear();
            this.errorProviderLastName.Clear();
            this.errorProviderPassword.Clear();
            
        }
        int getMonth() {

            int month=0;
            string m = this.comboBoxMonth.Text.ToLower();
            switch (m) {

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
        private bool ValidateData() {
            bool isFirstNameValid = false, isLastNameValid=false, isEmailValid=false, isDOBValid=false, isGenderValid=false, isPasswordValid=false, isAccTypeValid=false;
            clearAllErrors();
            Regex nameexp = new Regex(@"^[a-zA-Z\s]+$");

            if (this.textFirstName.Text.Trim().Length == 0 || !nameexp.IsMatch(this.textFirstName.Text.Trim()))
            {
                errorProviderFirstName.SetError(this.textFirstName, "Please enter valid name");

            }
            else {
                errorProviderFirstName.Clear();
                if(this.textFirstName.Text.Trim().Length <3) 
                    errorProviderFirstName.SetError(this.textFirstName, "Name should have atleast 3 characters");
                else
                isFirstNameValid = true;
            }

            if (this.textBoxLastName.Text.Trim().Length == 0 || !nameexp.IsMatch(this.textBoxLastName.Text.Trim()))
            {
                
                errorProviderLastName.SetError(this.textBoxLastName, "Please enter valid name");

            }
            else
            {
                errorProviderLastName.Clear();
                if (this.textBoxLastName.Text.Trim().Length<3)
                    errorProviderLastName.SetError(this.textBoxLastName, "Name should have atleast 3 characters");
                else
                isLastNameValid = true;
               
            }

            if (this.comboBoxGender.Text.ToString().ToLower() == "select gender")
            {
                
                errorProviderGender.SetError(this.comboBoxGender, "Please select a gender");
            }
            else
            {

                if (this.comboBoxGender.Items.Contains(this.comboBoxGender.Text) == false)
                {

                    errorProviderGender.SetError(this.comboBoxGender, "Please select a option from provided options");
                }
                else
                {
                    errorProviderGender.Clear();
                    isGenderValid = true;
                }
            }
            if (this.comboBoxMonth.Text.ToString().ToLower() == "month" || this.comboBoxDay.Text.ToString().ToLower() == "day" || this.comboBoxYear.Text.ToString().ToLower() == "year")
            {
                
                errorProviderbirthdate.SetError(this.comboBoxDay, "Please select date");
            }
            else
            {
                errorProviderbirthdate.Clear();

                int month=getMonth();
                String date = this.comboBoxDay.Text.ToString() + "/" + month + "/" + this.comboBoxYear.Text.ToString();
                DateTime dt;
                
                bool Valid = DateTime.TryParseExact(date, "d/M/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
                if (!Valid)
                {
                    errorProviderbirthdate.SetError(this.comboBoxDay, "Date is not valid");
                }
                else {
                    isDOBValid = true;
                    errorProviderbirthdate.Clear();
                }
            }


            if (this.comboBoxAccType.Text.ToString().ToLower() == "select account type")
            {
                
                errorProviderAccountType.SetError(this.comboBoxAccType, "Please select account type");
            }
            else
            {
                if (this.comboBoxAccType.Items.Contains(this.comboBoxAccType.Text) == false)

                    this.errorProviderAccountType.SetError(this.comboBoxAccType, "Please select option from the given options");
                else
                {
                    errorProviderAccountType.Clear();
                    isAccTypeValid = true;
                }
            }

            if (this.textBoxPassword.Text.Trim().Length == 0)
            {
               
                errorProviderPassword.SetError(this.textBoxPassword, "please enter a password");
            }
            else
            {
                errorProviderPassword.Clear();
                if (this.textBoxPassword.Text.Trim().Length < 7)
                {
                   
                    errorProviderPassword.SetError(this.textBoxPassword, "Enter atleast 8 characters");
                }
                else
                {
                    isPasswordValid = true;
                    errorProviderPassword.Clear();
                }
            }

            Regex emailexp = new Regex(@"^[a-zA-Z0-9]+[_.-]*[a-zA-Z0-9]+@[a-zA-Z]+(.com)$");

            if (this.textBoxEmailAddress.Text.Trim().Length == 0)
            {
                
                errorProviderEmail.SetError(this.textBoxEmailAddress, "plesae Enter email address");
            }
            else
            {
                errorProviderEmail.Clear();

                if (!emailexp.IsMatch(this.textBoxEmailAddress.Text.Trim()))
                {
                    
                    errorProviderEmail.SetError(this.textBoxEmailAddress, "Email address is not valid");
                }
                else
                {
                    isEmailValid = true;
                    errorProviderEmail.Clear();
                }
            }
            if (isDOBValid && isEmailValid && isFirstNameValid && isGenderValid && isLastNameValid && isPasswordValid && isAccTypeValid)
            {
                return true;
            }
            else
                return false;
        }
        FileProcessorMessageBox fileProcessorMessageBox;
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            // add data to database
           
            bool isValid=ValidateData();
            if (isValid) {

                int year = Convert.ToInt32(this.comboBoxYear.Text.Trim());
                DateTime dateTime = DateTime.UtcNow.Date;
                String currYear = dateTime.ToString("yyyy");
                int CurrYear = Convert.ToInt32(currYear);
                
                if (CurrYear - year < 12)
                {
                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show("You should have minimum 13 years age to use this system");
                    fileProcessorMessageBox.ShowDialog();
                   
                    goto outSide;
                
                }
                
                

                datacontext = new linqtosqlDataContext();
                User newUser = new User();
                int month = getMonth();

                String id = this.textFirstName.Text.Trim().Substring(0, 1)
                    + this.textBoxLastName.Text.Trim().Substring(this.textBoxLastName.Text.Trim().Length - 2, 1) +
                    this.textFirstName.Text.Trim().Substring(this.textFirstName.Text.Trim().Length / 2, 1);
                   
         
                String date = this.comboBoxDay.Text.ToString() + "/" + month + "/" + this.comboBoxYear.Text.ToString();
                 
                
                newUser.Id = id;
                newUser.FirstName = this.textFirstName.Text.Trim();
                newUser.LastName = this.textBoxLastName.Text.Trim();
                newUser.NewPassword = this.textBoxPassword.Text.Trim();
                newUser.AccountType = this.comboBoxAccType.SelectedItem.ToString();
                newUser.EmailAddress = this.textBoxEmailAddress.Text.Trim();
                newUser.DateOfBirth = date;
                newUser.Gender = this.comboBoxGender.SelectedItem.ToString();
                
                this.Hide();
                Loading loadForm = new Loading();
               // loadForm.setSecurityQuestionValue(newUser);
                loadForm.ShowDialog();

                SecurityCheck SecurityCheckForm = new SecurityCheck();
                SecurityCheckForm.ShowDialog(this);
               
                newUser.QuestionNo = this.questionNumber;
                newUser.Answer_ = this.answer;
                datacontext.Users.InsertOnSubmit(newUser);
                datacontext.SubmitChanges();

                // changed here
                UserActivit userActivity = new UserActivit();
                userActivity.UserId = id;
                datacontext.UserActivits.InsertOnSubmit(userActivity);
                datacontext.SubmitChanges();
                // to here 

                loadForm = new Loading();
                loadForm.ResetBarValue();
                loadForm.ShowDialog();

                FileProcessorMessageBox = new FileProcessorMessageBox();
                FileProcessorMessageBox.Show("Your user id is: " + id);
                FileProcessorMessageBox.ShowDialog();

                this.Dispose();
            }

        outSide:

            int temp;
           

        }
        FileProcessorMessageBox FileProcessorMessageBox;

        internal String answer;
        internal int questionNumber;
        internal void SetSecurityQuestionValues(int questionNo, string answer) {
           
            this.questionNumber = questionNo; this.answer = answer;
        }
        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
