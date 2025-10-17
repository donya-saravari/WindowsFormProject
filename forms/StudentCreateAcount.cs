using firstSessionwindowsform.classes;
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
using firstSessionwindowsform.classes;
using firstSessionwindowsform.Help;
namespace firstSessionwindowsform
{
    public partial class StudentCreateAcount : Form
    {
        public StudentCreateAcount()
        {
            InitializeComponent();
        }

        private void createAcountButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(userName: UserNameTextBox.Text, password: PasswordTextBox.Text);
            student.SfirstName = firstNameTextBox.Text;
            student.SlastName = lastNameTextBox.Text;
            student.SponeNumber = phoneNumberTextBox.Text;
            student.SnationalCode = nationalCodeTextBox.Text;
            student.SBirthDate = DateTime.Parse(AgeDateTimePicker.Text);
            List<Student> students = new List<Student>();
            students.Add(student);
            PhoneNumberHelper.IsValidPhoneNumber(student.SponeNumber);
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
