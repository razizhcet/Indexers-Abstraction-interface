using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    class Arithematic
    {
        int num1, num2, result;
        public int pNum1
        {
            set { num1 = value; }
        }
        public int pNum2
        {
            set { num2 = value; }
        }
        public int pResult
        {
            get { return result; }
        }
        public void Add()
        {
            result = num1 + num2;
        }
        public void Subtract()
        {
            result = num1 - num2;
        }
        public void Multiply()
        {
            result = num1 * num2;
        }
        public void Division()
        {
            result = num1 / num2;
        }
    }
    class PropertyReadWrite
    {
        static void Main(string[] args)
        {
            Arithematic arth = new Arithematic();
            Console.WriteLine("Enter two numbers:");
            arth.pNum1 = Convert.ToInt32(Console.ReadLine());
            arth.pNum2 = Convert.ToInt32(Console.ReadLine());

            arth.Add();
            Console.WriteLine("Sum is : " + arth.pResult);
            arth.Subtract();
            Console.WriteLine("Diffrence is : " + arth.pResult);
            arth.Multiply();
            Console.WriteLine("product is : " + arth.pResult);
            arth.Division();
            Console.WriteLine("Quotient is : " + arth.pResult);
            Console.ReadKey();
        }
    }
}
