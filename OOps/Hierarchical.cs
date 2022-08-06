using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    class Base
    {
        public int a = 20, b = 30, c = 0;
        public void Add()
        {
            c = a + b;
            Console.WriteLine("Addition is\t" + c);
        }
    }
    class Hierarchical:Base
    {
        public void Sub()
        {
            c = a - b;
            Console.WriteLine("Subtraction is\t" + c);
        }
    }
    class Hierarchical1:Base
    {
        public void Multi()
        {
            c = a * b;
            Console.WriteLine("Multiplication is\t" + c);
        }
    }

}
