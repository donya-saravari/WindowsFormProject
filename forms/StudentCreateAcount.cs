using BaseBackend.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BaseBackend.classes;
using firstSessionwindowsform.Help;
using BaseBackend.Services;
namespace firstSessionwindowsform
{
    public partial class StudentCreateAcount : Form
    {
        StudentService studentService;
        public StudentCreateAcount()
        {
            InitializeComponent();
            studentService = new StudentService();
        }
        public static bool ValidateStudent(List<Student> students,string UserName, string password)
        {
            return students.Any(s=> s.UserName == UserName && s.Password == password);
        }

        private void createAcountButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(userName: UserNameTextBox.Text, password: PasswordTextBox.Text);
            student.SfirstName = firstNameTextBox.Text;
            student.SlastName = lastNameTextBox.Text;
            student.SphoneNumber = phoneNumberTextBox.Text;
            student.SnationalCode = nationalCodeTextBox.Text;
            student.SBirthDate = AgeDateTimePicker.Value;
            student.Date = registerDatedateTimePicker.Value;
            studentService.Add(student);
            PhoneNumberHelper.IsValidPhoneNumber(student.SphoneNumber);
            ResetForm();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            studentIdTextBox.Text = null;
            firstNameLabel.Text = null;
            lastNameLabel.Text = null;
            phoneNumberTextBox.Text = null;
            nationalCodeTextBox.Text = null;
            AgeDateTimePicker.Text = null;
            registerDatedateTimePicker.Text = null;
            UserNameTextBox.Text = null;
            PasswordTextBox.Text = null;

        }
    }
}
