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
        public Course(string Course)
        {
            Course = Course;
        }
        public List<CourseList> courseLists { get; set; }
        public List<Course> Courses { get; set; }
        public string CourseTitle { get;}
        public string Info { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get;}
        public Teacher Teacher { get; }
        public int Capacity { get; }
        public bool Available { get; }
    }
}
