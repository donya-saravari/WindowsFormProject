using firstSessionwindowsform.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.Services
{
    public class CourseService : BaseService<Course>
    {
        List<Course> courses = new List<Course>();
        public void Add(Course course)
        {
            courses.Add(course);
        }
        public List<Course> GetAll()
        {
            return courses;
        }
    }
}
