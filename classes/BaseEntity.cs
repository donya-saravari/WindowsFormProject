using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.classes
{
   public abstract class  BaseEntity
    {
        public BaseEntity() 
        {
            Date = DateTime.Now;
        }
        public int Id { get; }
        public DateTime Date { get; set; }
    }
}
