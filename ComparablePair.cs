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
        public T t { get; set; }
        public U u { get; set; }

        public ComparablePair(T t, U u)
        {
            this.t = t;
            this.u = u;
        }

        

        public int CompareTo(ComparablePair<T, U> obj) 
        {
            int temp = t.CompareTo(obj.t);
            
            return temp != 0 ? temp : this.u.CompareTo(obj.u);

        }


    }
}
