using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_22
{
    public class MathAck { };

    public class MathIndex : MathAck
    {
        int id;

        public MathIndex(int id)
        {
            this.id = id; 
        }
    }

    public class MathDegate
    {
        public delegate void DeGte(object obj, MathAck mathAck);

        DeGte DeG;

    }
    class Class1
    {
    }
}
