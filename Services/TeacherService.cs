using firstSessionwindowsform.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.Services
{
    public class TeacherService: BaseService<Teacher>
    {
        List<Teacher> teachers = new List<Teacher>();
        public void Add(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public List<Teacher> GetAll()
        {
            return teachers;
        }
    }
}
