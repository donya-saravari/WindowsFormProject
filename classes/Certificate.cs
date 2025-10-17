using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstSessionwindowsform.enums;
namespace firstSessionwindowsform.classes
{
    class Certificate : BaseEntity
    {
        public Student StudentId { get; }
        public Course CourseId { get; }
        public DateTime CertificateDate { get; }
        public CertificateStatus Status { get; }
    }
}
