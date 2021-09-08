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
namespace DataFilter
{
    public partial class ForgetPassword : Form
    {
        linqtosqlDataContext dataContext;
        bool HideOrShow1, HideOrShow2;
        public ForgetPassword()
        {
            InitializeComponent();
            dataContext = new linqtosqlDataContext();
            this.panelVerifyAnswer.Location = this.panelVerifyId.Location;
            this.panelChangePassword.Location= this.panelVerifyId.Location;
        }

        
        public ForgetPassword(User currUser ) {

            InitializeComponent();
            dataContext = new linqtosqlDataContext();

            user = dataContext.Users.SingleOrDefault(record => record.Id == currUser.Id);
            this.UserId = user.Id;
            this.panelVerifyAnswer.Location = this.panelVerifyId.Location;
            this.panelChangePassword.Location = this.panelVerifyId.Location;
            this.panelVerifyId.Visible = false;
            this.labelUserName.Text = user.FirstName.Trim() + " " + user.LastName.Trim();
            int questionNo = (int)user.QuestionNo - 1;
            this.label2.Location = new Point(this.label2.Location.X - 50, this.label2.Location.Y);
            SecurityCheck SecurityCheckForm = new SecurityCheck();
            this.label2.Text = SecurityCheckForm.comboBoxSecurtyQues.Items[questionNo].ToString();
            this.panelVerifyAnswer.Visible = true;
          
        }
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            HideOrShow1 = true;
            HideOrShow2 = true;
            this.buttonShowPass.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
            this.buttonShowPass.BackgroundImageLayout = ImageLayout.Zoom;
            this.buttonShowRepeatPass.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
            this.buttonShowRepeatPass.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        FileProcessorMessageBox fileProcessorMessageBox;
        private void btnVerifyAnswer_Click(object sender, EventArgs e)
        {
            if (this.textBoxVerifyAnswer.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(this.textBoxVerifyAnswer, "Please write your answer");
            }
            else
            {
                if (this.textBoxVerifyAnswer.Text.Trim().ToLower() == this.user.Answer_.Trim().ToLower())
                {
                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show("Answer verfied");
                    fileProcessorMessageBox.ShowDialog();
                   
                    this.panelVerifyAnswer.Visible = false;
                    this.panelChangePassword.Visible = true;
                }
                else
                {
                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show("Answer does not match");
                    fileProcessorMessageBox.ShowDialog();
                

                }
            }
        }
        String UserId; User user; UserActivit userAct;
        private void btnVerifyUserID_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (this.textBoxVerifyId.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(this.textBoxVerifyId, "Please enter your user id");
            }
            else
            {
                UserId = this.textBoxVerifyId.Text.Trim();
                user = dataContext.Users.SingleOrDefault(record => record.Id == UserId);
                if (user != null)
                {
                    SecurityCheck SecurityCheckForm = new SecurityCheck();
                    this.panelVerifyId.Visible = false;
                    this.labelUserName.Text = user.FirstName.Trim() + " " + user.LastName.Trim();
                    int questionNo = (int)user.QuestionNo - 1;
                    this.label2.Location = new Point(this.label2.Location.X - 50,this.label2.Location.Y);
                    this.label2.Text = SecurityCheckForm.comboBoxSecurtyQues.Items[questionNo].ToString();
                    this.panelVerifyAnswer.Visible = true;

                }
                else
                {
                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show("Incorrect User Id");
                    fileProcessorMessageBox.ShowDialog();
                }
            }
        }

        private void btnVerifyIdClose_Click(object sender, EventArgs e)
        {
            
            MainPage MainPageForm = new MainPage();
            MainPageForm.Show();
            this.Dispose();
        }

        private void btnVerfyAnswerClose_Click(object sender, EventArgs e)
        {
            MainPage MainPageForm = new MainPage();
            MainPageForm.Show();
            this.Dispose();
        }

        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            if (!HideOrShow1)
            {
                this.buttonShowPass.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
                this.buttonShowPass.BackgroundImageLayout = ImageLayout.Zoom;
                HideOrShow1 = !HideOrShow1;
                this.textBoxNewPass.PasswordChar = '*';
            }
            else
            {
                this.buttonShowPass.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\show.png");
                this.buttonShowPass.BackgroundImageLayout = ImageLayout.Zoom; HideOrShow1 = !HideOrShow1;
                this.textBoxNewPass.PasswordChar = '\0';
            }
        }

        private void panelVerifyAnswer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            if (this.textBoxNewPass.Text.Length == 0)
            {

                this.errorProvider1.SetError(this.textBoxNewPass, "Please Enter new password");

            }
            
            else {
                if (this.textBoxRepeatPass.Text.Length == 0)
                {

                    this.errorProvider2.SetError(this.textBoxRepeatPass, "Please enter new password");
                }
                else if (this.textBoxNewPass.Text == this.textBoxRepeatPass.Text)
                {
                    user.NewPassword = this.textBoxNewPass.Text;
                    //dataContext.SubmitChanges();
                    this.Hide();
                    userAct = new UserActivit();
                    userAct.UserId = UserId;
                    userAct.Activity="password changed "+ DateTime.Now+"";
                    dataContext.UserActivits.InsertOnSubmit(userAct);
                    dataContext.SubmitChanges();

                    RedirectForm redirect = new RedirectForm();
                    redirect.ShowDialog();
                    fileProcessorMessageBox = new FileProcessorMessageBox();
                    fileProcessorMessageBox.Show("Password changes successfully");
                    fileProcessorMessageBox.ShowDialog();
                    

                    MainPage MainPageForm = new MainPage();
                    MainPageForm.Show();
                    this.Dispose();

                }
                else {

                    this.errorProvider2.SetError(this.textBoxRepeatPass,"Passowrd not matched");
                }


            }
        }

        private void buttonPasswordChangeClose_Click(object sender, EventArgs e)
        {


            MainPage MainPageForm = new MainPage();
            MainPageForm.Show();
            this.Dispose();
        }

        private void buttonShowRepeatPass_Click(object sender, EventArgs e)
        {
            if (!HideOrShow2)
            {
                this.buttonShowRepeatPass.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\hide.png");
                this.buttonShowRepeatPass.BackgroundImageLayout = ImageLayout.Zoom;
                HideOrShow2 = !HideOrShow2;
                this.textBoxRepeatPass.PasswordChar = '*';
            }
            else
            {
                this.buttonShowRepeatPass.BackgroundImage = Image.FromFile(@"C:\Users\nigeetawadhwani\source\repos\DataFilter\show.png");
                this.buttonShowRepeatPass.BackgroundImageLayout = ImageLayout.Zoom; HideOrShow2 = !HideOrShow2;
                this.textBoxRepeatPass.PasswordChar = '\0';
            }
        }
    }
}
