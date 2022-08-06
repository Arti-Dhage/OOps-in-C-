using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    class Runtime_Polymo
    {
        public void Fun()
        {
            Console.WriteLine("Inside Runtime poly");
        }
    }
    class Runtime_Polymo1:Runtime_Polymo
    {
        public void Fun()
        {
            base.Fun();
            Console.WriteLine("Inside Runtime poly1");
        }
    }

}
