using System;

namespace Overloading_Overloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            MathClass mc = new MathClass();
            result = mc.Add(3);
            result = mc.Add(55, 190);
           
        }
    }
}
