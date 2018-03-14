using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexresProject
{
    class Employee
    {
        int Eid;
        string Ename;
        double Esalary;
        string Epost, Edpt, Location;

        public Employee(int Eid, string Ename, double Esalary, string Epost, string Edpt, string Location)
        {
            this.Eid = Eid;
            this.Ename = Ename;
            this.Esalary = Esalary;
            this.Epost = Epost;
            this.Edpt = Epost;
            this.Edpt = Edpt;
            this.Location = Location;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Eid;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Esalary;
                else if (index == 3)
                    return Epost;
                else if (index == 4)
                    return Edpt;
                else if (index == 5)
                    return Location;
                return null;
            }
            set
            {
                if (index == 0)
                    Eid = (int)value;
                else if (index == 1)
                    Ename = (string)value;
                else if (index == 2)
                    Esalary = (double)value;
                else if (index == 3)
                    Epost = (string)value;
                else if (index == 4)
                    Edpt = (string)value;
                else if (index == 5)
                    Location = (string)value;
            }
        }
        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "EID")
                    return Eid;
                else if (name.ToUpper() == "ENAME")
                    return Ename;
                else if (name.ToUpper() == "ESALARY")
                    return Esalary;
                else if (name.ToUpper() == "EPOST")
                    return Epost;
                else if (name.ToUpper() == "EDPT")
                    return Edpt;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                return null;
            }
            set
            {
                if (name.ToUpper() == "EID")
                    Eid = (int)value;
                else if (name.ToUpper() == "ENAME")
                    Ename = (string)value;
                else if (name.ToUpper() == "ESALARY")
                    Esalary = (double)value;
                else if (name.ToUpper() == "EPOST")
                    Epost = (string)value;
                else if (name.ToUpper() == "EDPT")
                    Edpt = (string)value;
                else if (name.ToUpper() == "LOCATION")
                    Location = (string)value;
            }
        }
        public void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Employee));
            try
            {
                string str = String.Empty;
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message);
            }
        }
    }
    class TestEmployee
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(TestEmployee));
        static void Main(string[] args)
        {
            Employee emp = new Employee(901, "Razi", 15000.00, "trainee", "Dotnet", "BLR");
            Console.WriteLine("Eid : " + emp[0]);
            Console.WriteLine("Ename : " + emp[1]);
            Console.WriteLine("Esalary : " + emp[2]);
            Console.WriteLine("Epost : " + emp[3]);
            Console.WriteLine("Edpt : " + emp[4]);
            Console.WriteLine("Location : " + emp[5]);

            emp["ESALARY"] = 20000.00;
            emp[3] = "Developer";
            Console.WriteLine("Modified values");

            log.Info("Eid : " + emp["Eid"]);
            Console.WriteLine("Ename : " + emp["Ename"]);
            Console.WriteLine("Esalary : " + emp["Esalary"]);
            Console.WriteLine("Epost : " + emp["Epost"]);
            Console.WriteLine("Edpt : " + emp["Edpt"]);
            Console.WriteLine("Location : " + emp["Location"]);

            emp.Testing();
            Console.ReadKey();
        }
    }
}
