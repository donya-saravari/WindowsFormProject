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

namespace firstSessionwindowsform.forms
{
    public partial class Admin : Form
    {
        List<Course> courses;
        public Admin()
        {
            InitializeComponent();
            courses = new List<Course>();
            FillDateGrid(courses);

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string Course = CourseTextBox.Text;
            //DateTime RegisterDate = RegisterDateTimePicker.
            //DateTime ExamDate = ExamDateTimePicker.
            Course course = new Course(Course : CourseTextBox.Text);
            courses.Add(course);
            FillDateGrid(courses);
        }
        private void FillDateGrid(List<Course> courses)
        {
            CoursesDataGridView.DataSource = null;
            CoursesDataGridView.DataSource = courses;
            CoursesDataGridView.Refresh();
        }
       
    }
}
