using firstSessionwindowsform.classes;
using firstSessionwindowsform.forms;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace firstSessionwindowsform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            string UserName = UserNameTextBox.Text;
            string Password = PasswordTextBox.Text;
            if (TeacherRadioButton.Checked)
            {
                Dashbord dashbord = new Dashbord();
                dashbord.Show();
            }
            else if (StudentRadioButton.Checked)
            {
                if (StudentCreateAcount.ValidateStudent(students,UserName, Password))
                {
                    EnglishForm landingPage = new EnglishForm();
                    landingPage.Show();
                }
            }
            else
            {
                string error = "Please check a radio button";
                RadioButtoErrorProvider.SetError(RadioButtonGroupBox, error);
            }


        }

        private void CreateAcountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TeacherRadioButton.Checked)
            {
                TeacherCreateAcount teacherCreateAcount = new TeacherCreateAcount();
                teacherCreateAcount.Show();
            }
            else if (StudentRadioButton.Checked)
            {
                StudentCreateAcount studentCreateAcount = new StudentCreateAcount();
                studentCreateAcount.Show();
            }
            else
            {
                string error = "Please check a radio button";
                RadioButtoErrorProvider.SetError(RadioButtonGroupBox, error);
            }
        }
    }
}
