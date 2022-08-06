using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    class Abstractions
    {
        private void run()
        {
            int n = 2;
            Console.WriteLine("Inside run");
        }
    }
    class Abstractions1:Abstractions
    {
        public void gun()
        {
            Console.WriteLine("Inside gun");
        }
    }
}
