using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.classes
{
    public class Feedback : BaseEntity
    {
        public Feedback() : base() { }
        public Student studentId  { get; }
        public Course courseId { get; }
        public string Info { get; set; }
        public DateTime FeedbackDate { get;}
    }
}
