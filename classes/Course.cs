using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace firstSessionwindowsform.classes
{
    class Course : BaseEntity
    {
        public Course(string Course)
        {
            Course = Course;
        }
        public string CourseTitle { get;}
        public string Info { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get;}
        public Teacher Teacher { get; }
        public int Capacity { get; }
        public bool Available { get; }
    }
}
