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
            FillDateGrid(courseServices.GetAll());

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string Course = CourseTextBox.Text;
            DateTime RegisterDate = RegisterDateTimePicker.Value;
            DateTime ExamDate = ExamDateTimePicker.Value;
            Course course = new Course(Course : CourseTextBox.Text);
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
