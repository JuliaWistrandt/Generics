using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Pair<S, T> 
        where S : struct 
        where T : struct
    {

        public S Svalue { get; set; }
        public T Tvalue { get; set; }

        public Pair(S s, T t)
        {
            Svalue = s;
            Tvalue = t;
        }

        public override string ToString() => $"({Svalue}, {Tvalue})";

    }
}
