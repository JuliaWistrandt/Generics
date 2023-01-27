using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class PairClass<S, T>
        where S : class?
        where T : class?
    {

        public S Svalue { get; set; }
        public T Tvalue { get; set; }

        public PairClass(S s, T t)
        {
            Svalue = s;
            Tvalue = t;
        }

        public override string ToString() => $"({Svalue}, {Tvalue})";


    }
    
}
