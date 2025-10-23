using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace firstSessionwindowsform.classes
{
    public class Course : BaseEntity
    {
        public Course() : base() { }
        public Course(string Course, DateTime startDate, DateTime examDate, Teacher fullname , int capacity , bool available ,int price)
        {
            CourseTitle = Course;
            StartDate = startDate;
            ExamDate = examDate;
            FullName = fullname;
            Capacity = capacity;
            Available = available;
            Price = price;
        }
        public Teacher SelectedTeacher { get; set; }
        public Course (Teacher fullname)
        {
            SelectedTeacher = fullname;
        }
        public List<CourseList> courseLists { get; set; }
        public List<Course> Courses { get; set; }
        public string CourseTitle { get; set; }
        public string Info { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExamDate { get; set; }
        public Teacher FullName { get; set; }
        
        public int Capacity { get; set; }
        public bool Available { get; set; }
        public int Price { get; set; }
    }
}
