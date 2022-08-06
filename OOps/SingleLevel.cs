using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    //single level inharitance
    class SingleLevel
    {
        protected int a = 20, b = 30, c = 0;
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
    class SingleLevel1:SingleLevel
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
}
