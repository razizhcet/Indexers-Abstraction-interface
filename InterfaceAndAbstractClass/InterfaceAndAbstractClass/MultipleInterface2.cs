using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    interface Interface1
    {
        void f1();
    }
    interface Interface2
    {
        void f1();
    }
    class C : Interface1, Interface2
    {
        //public void f1()
        void Interface1.f1()
        {
            Console.WriteLine("Welcome");
        }
        void Interface2.f1()
        {
            Console.WriteLine("Hello");
        }
    }
    class MultipleInterface2
    {
        static void Main(string[] args)
        {
            C c1 = new C();

            Interface1 if1 = (Interface1)c1;
            Interface2 if2 = (Interface2)c1;

            if1.f1();
            if2.f1();
            Console.ReadKey();
        }
    }
}
