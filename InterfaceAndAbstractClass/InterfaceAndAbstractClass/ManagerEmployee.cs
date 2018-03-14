using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    interface Employee
    {
        void GetEmpData();
        void DisplayEmpData();
    }
    class ManagerEmployee : Employee
    {
        int EmpId;
        string Name;
        double Salary, Bonus;
            
        public void GetEmpData()
        {
            Console.WriteLine("Enter Employee details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.Name = Console.ReadLine();
            this.Salary = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("Employee ID is : " + EmpId);
            Console.WriteLine("Employee name is : " + Name);
            Console.WriteLine("Employee salary is : " + Salary);
            Console.WriteLine("Employee bonus is : " + Bonus);
        }
    }
    class Manager
    {
        static void Main(string[] args)
        {
            ManagerEmployee me = new ManagerEmployee();
            me.GetEmpData();
            me.DisplayEmpData();
            Console.ReadKey();
        }
    }
}
