using firstSessionwindowsform.classes;
using firstSessionwindowsform.forms;
using Newtonsoft.Json;
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
            string pathTeacherList = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Teacher.json");
            if (!File.Exists(pathTeacherList))
            {
                MessageBox.Show("Invalid Path");
                return;
            }

            if (TeacherRadioButton.Checked)
            {

                string TeacherContentList = File.ReadAllText(pathTeacherList);
                List<TeacherList> teacherLists = JsonConvert.DeserializeObject<List<TeacherList>>(TeacherContentList);
                var LoginTeacher = teacherLists.Where(teacher => teacher.UserName == UserName && teacher.Password == Password).First();
                
                if (LoginTeacher != null) {
                    {
                        Dashbord dashbord = new Dashbord();
                        dashbord.ShowDialog();
                        return;
                    }
                }
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
