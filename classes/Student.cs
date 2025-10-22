using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.classes
{
   public class Student : BaseEntity
    {
        public Student():base()
        { }
        public Student(string userName, string password) {
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(userName));
            }
            UserName = userName;
            Password = password;
        }
        public string SfirstName { get; set; }
        public string SlastName { get; set; }
        public string FullName { get {
                return SfirstName+" "+SlastName;
            }
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SphoneNumber { get; set; }
        public string SnationalCode { get; set; }
        public DateTime SBirthDate { get; set; }
        public DateTime registerDate { get;}
        public int Age { get{
                if (SBirthDate == DateTime.MinValue)
                {
                    throw new Exception();
                }return DateTime.Now.Year - SBirthDate.Year;
            }

        }
       
    }
}
