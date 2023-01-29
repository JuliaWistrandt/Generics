using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic 
{

    class ComparablePair<T, U> : IComparable<ComparablePair<T, U>> where T : IComparable<T> where U : IComparable<U>
    {
        int temp;
        public T t { get; set; }
        public U u { get; set; }

        public ComparablePair(T t, U u)
        {
            this.t = t;
            this.u = u;
        }

        public string ComparePair(int temp)
        {
            if (temp == 0) // The properties are the same.
                return "The properties occur in the same position in the sort order.";
            else if (temp < 0)
                return "The first property precedes the second in the sort order.";
            else
                return "The first property follows the second in the sort order.";

        }

        

        public int CompareTo(ComparablePair<T, U> obj) 
        {
            temp = t.CompareTo(obj.t);
            ComparePair(temp);
            
            return temp;

        }
        //alternative return temp!= 0 ? temp : this.u.CompareTo(obj.u);

    }
}
