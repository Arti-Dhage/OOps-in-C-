using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    class MethodOverloading
    {
        public string name = "Hello Rushikesh";

        public int Add(int No1,int No2)
        {
            return No1 + No2;
        }public int Add(int No1,int No2,int No3)
        {
            return No1 + No2+No3;
        }
    }
}
