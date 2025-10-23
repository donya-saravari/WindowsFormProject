using firstSessionwindowsform.classes;
using firstSessionwindowsform.Services;
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
    public partial class AdminForm : Form
    {
        CourseService courseServices;
        public AdminForm()
        {
            InitializeComponent();

            courseServices = new CourseService();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            Teacher SelectedTeacher = (Teacher) TeacherComboBox.SelectedItem;
            Course course = new Course(Course : CourseTextBox.Text, startDate: RegisterDateTimePicker.Value, examDate: ExamDateTimePicker.Value,
                                        fullname: SelectedTeacher, capacity: int.Parse(CapacityNumericUpDown.ToString()), available: AvailableCheckBox.Checked, price: int.Parse(PriceTextBox.Text));
            courseServices.Add(course);
            FillDateGrid(courseServices.GetAll());
        }
        private void FillDateGrid(List<Course> courses)
        {
            CoursesDataGridView.DataSource = null;
            CoursesDataGridView.DataSource = courses;
            CoursesDataGridView.Refresh();
        }
       
    }
}
