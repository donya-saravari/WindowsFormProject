using firstSessionwindowsform.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.Services
{
    public class StudentService : BaseService<Student>
    {
        List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }
        public List<Student> GetAll() { 
         return students;
        }
    }
}
