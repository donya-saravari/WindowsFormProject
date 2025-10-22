using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.classes
{
    public class Exam : BaseEntity
    {
    public Exam() : base() { }
    public Course Id { get; set; }
    public int Score { get; }
    public DateTime ExamDate { get; }

}
}
