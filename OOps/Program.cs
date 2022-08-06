using System;

namespace OPPS
{
    class Program
    {
        //default constuctor
        Program()
        {
            Console.WriteLine("Inside Default Constrocter");
        }
        //parameterized constructor
        Program(int a, int b)
        {
            Console.WriteLine("Inside Paramiterized Constrocter\t" + (Convert.ToInt32(a + b)));
        }
        static void Main(string[] args)
        {
            // Constructor
            Console.WriteLine("Constrocters");
            Program p1 = new Program();     //default constroctor
            Program p = new Program(11, 22); // parameterized constroctor

            // Encapsulation
            Console.WriteLine();
            Console.WriteLine("Encapsulation");
            Encapsulation E = new Encapsulation();
            //Program e = new Encapsulation();
            E.setValue(8876);
            Console.WriteLine("ATM Pin is\t" + E.getValue());
            // Method Overloading:-used for achieved compile time polymorphism 
            Console.WriteLine();
            Console.WriteLine("Method Overloading");
            MethodOverloading s1 = new MethodOverloading();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.Add(10, 20));
            // single level inharitance
            Console.WriteLine();
            Console.WriteLine("Single_level Inharitance");
            SingleLevel1 r = new SingleLevel1();
            r.Add();
            r.Sub();
            r.Multi();
            r.Div();
            // Multi_Level Inharitance
            Console.WriteLine();
            Console.WriteLine("Multi_level Inharitance");
            MultiLevel2 m = new MultiLevel2();
            m.Add();
            m.Sub();
            m.Multi();
            m.Div();
            m.Mod();

            // Multiple Inharitance
            Console.WriteLine();
            Console.WriteLine("Multiple Inharitance");
            Multiple M = new Multiple();
            M.Add();
            M.Sub();

            // Hierarchical Inharitance
            Console.WriteLine();
            Console.WriteLine("Hierarchical Inharitance");
            Hierarchical h = new Hierarchical();
            h.Add();
            h.Sub();
            Hierarchical1 h1 = new Hierarchical1();
            h1.Add();
            h1.Multi();
            // Runtime Polymorphism
            Console.WriteLine();
            Console.WriteLine("Runtime Polymorphism");
            Runtime_Polymo1 poly1 = new Runtime_Polymo1();
            poly1.Fun();

            //Abstractions
            Console.WriteLine();
            Console.WriteLine("Abstractions");
            Abstractions1 A1 = new Abstractions1();
            // A1.run();//achieved abstraction
            A1.gun();
        }
    }
}
