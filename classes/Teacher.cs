using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace firstSessionwindowsform.classes
{
   public class Teacher : BaseEntity
    {
        public Teacher(): base() { }
        public Teacher(string nationalCode, string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nationalCode))
            {
                throw new ArgumentNullException(nameof(userName));
            }
            UserName = userName;
            Password = password;
            TnationalCode = nationalCode;
        
        }
        public string TfirstName { get; set; }
        public string TlastName { get; set; }
        public string FullName
        {
            get
            {
                return TfirstName + " " + TlastName;
            }
            set
            {
                var names = value.Split(' ');
                if (names.Length > 1)
                {
                    TfirstName = names[0];
                    TlastName = names[1];
                }
                else
                {
                    TfirstName = value;
                    TlastName = string.Empty;
                }
            }
        }
        public Teacher(string fullname)
        {
            FullName = fullname;
        }
        public override string ToString()
        {
            return FullName;
        }
        public string TphoneNumber { get; set; }
        public string TnationalCode { get; set; }
        public DateTime TBirthDate { get; set; }
        public int Tdegree { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public int Age
        {
            get
            {
                if (TBirthDate == DateTime.MinValue)
                {
                    throw new Exception();
                }
                return DateTime.Now.Year - TBirthDate.Year;
            }

        }
    }
}
