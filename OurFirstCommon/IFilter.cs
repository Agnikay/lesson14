using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Lessons.Filters
{
    public interface IFilter<T>
    {
        bool IsSatisfied(T item);
    }
}
