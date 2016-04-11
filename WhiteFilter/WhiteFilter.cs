using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Lessons.Filters
{
    public class WhiteFilter<T> : IFilter<T>
    {
        public bool IsSatisfied(T item)
        {
            throw new NotImplementedException();
        }
    }
}
