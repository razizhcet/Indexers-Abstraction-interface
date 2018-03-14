using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    class BankBranch
    {
        int bCode;
        string bName;
        string bAddress;
        public void GetBdata()
        {
            Console.WriteLine("Enter branch details:");
            this.bCode = Convert.ToInt32(Console.ReadLine());
            this.bName = Console.ReadLine();
            this.bAddress = Console.ReadLine();
        }
        public void DisplayBdata()
        {
            Console.WriteLine("Branch details are:");
            Console.WriteLine("Branch code is:" + this.bCode);
            Console.WriteLine("Branch name is:" + this.bName);
            Console.WriteLine("Branch address is:" + this.bAddress);
        }
    }
    interface BankEmployee
    {
        void GetEmpData();
        void DisplayEmpData();
    }
    class Bank : BankBranch, BankEmployee
    {
        int empId;
        string eName;
        double salary;
        public void GetEmpData()
        {
            Console.WriteLine("Enter Employee details:");
            this.empId = Convert.ToInt32(Console.ReadLine());
            this.eName = Console.ReadLine();
            this.salary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Employee details are:");
            Console.WriteLine("Employee id is:" + this.empId);
            Console.WriteLine("Employee name is:" + this.eName);
            Console.WriteLine("Employee salary is:" + this.salary);
        }
    }
    class MultipleInheritance1
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.GetBdata();
            bank.GetEmpData();
            bank.DisplayBdata();
            bank.DisplayEmpData();
            Console.ReadKey();
        }
    }
}
