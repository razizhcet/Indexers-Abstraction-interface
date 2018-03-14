using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    class Studend
    {
        int Id;
        string Name;
        int Age;

        public int pId
        {
            set { Id = value; }
            get { return Id; }
        }
        public string pName
        {
            set { Name = value; }
            get { return Name; }
        }
        public int pAge
        {
            set { Age = value; }
            get { return Age; }
        }
    }
    class PropertiesAbstraction
    {
        static void Main(string[] args)
        {
            Studend std = new Studend();
            Console.WriteLine("Enter student details:");
            std.pId = Convert.ToInt32(Console.ReadLine());
            std.pName = Console.ReadLine();
            std.pAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student details are:");
            Console.WriteLine("Student id is:" + std.pId);
            Console.WriteLine("Student name is:" + std.pName);
            Console.WriteLine("Student age is:" + std.pAge);
            Console.ReadKey();
        }
    }
}
