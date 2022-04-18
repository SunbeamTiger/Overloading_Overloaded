using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Overloaded
{
    class MathClass
    {
        public int Add (int num)
        {
           return  num + num;
        }
        public int Add(int num, int num2)
        {
            return num + num2;
        }
    }
}
