using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    class MultiLevel
    {
        public int a = 20, b = 30, c = 0;
        public void Add()
        {
            c = a + b;
            Console.WriteLine("Addition is\t" + c);
        }
        public void Sub()
        {
            c = a - b;
            Console.WriteLine("Subtraction is\t" + c);
        }
    }
    class MultiLevel1:MultiLevel
    {
        public void Multi()
        {
            c = a * b;
            Console.WriteLine("Multiplication is\t" + c);
        }
        public void Div()
        {
            c = a / b;
            Console.WriteLine("Division is\t" + c);
        }
    }
    class MultiLevel2:MultiLevel1
    {
        public void Mod()
        {
            c = a % b;
            Console.WriteLine("Mod is\t" + c);
        }
    }
}
