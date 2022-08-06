using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    interface A
    {
        void Add(); //by default public
    }
    interface B
    {
        void Sub(); //by default public
    }

    class Multiple:A,B
    {
        public void Add()
        {
            int a = 10, b = 20;
            Console.WriteLine(a + b);
        }
        public void Sub()
        {
            int a = 10, b = 20;
            Console.WriteLine(a - b);
        }

    }
}
