using BaseBackend.classes;
using firstSessionwindowsform.Help;
using BaseBackend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstSessionwindowsform.forms
{
    public partial class TeacherCreateAcount : Form
    {
        TeacherService teacherService;
        public TeacherCreateAcount()
        {
            InitializeComponent();
            teacherService = new TeacherService();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            TeacherIDTextBox.Text = null;
            firstNameLabel.Text = null;
            lastNameLabel.Text = null;
            phoneNumberTextBox.Text = null;
            nationalCodeTextBox.Text = null;
            DegreeComboBox.SelectedIndex = 0;
            BirthDateDateTimePicker.Text = null;
            registerDatedateTimePicker.Text = null;

        }

        private void createAcountButton_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(nationalCode: nationalCodeTextBox.Text, userName: UserNameTextBox.Text, password: PasswordTextBox.Text);
            teacher.TfirstName = firstNameTextBox.Text;
            teacher.TlastName = lastNameTextBox.Text;
            teacher.TphoneNumber = phoneNumberTextBox.Text;
            teacher.TnationalCode = nationalCodeTextBox.Text;
            teacher.Tdegree = DegreeComboBox.SelectedIndex;
            teacher.TBirthDate = BirthDateDateTimePicker.Value;
            teacher.Date = registerDatedateTimePicker.Value;
            List<Teacher> teachers = new List<Teacher>();
            teacherService.Add(teacher);
            PhoneNumberHelper.IsValidPhoneNumber(teacher.TphoneNumber);
            ResetForm();
        }
    }
}
