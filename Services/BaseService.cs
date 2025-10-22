using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.Services
{
    public interface BaseService<T> 
    {
        void Add(T item);
        List<T> GetAll();
    }
}
