using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    abstract class Car
    {
        protected int modelNo;
        protected string make;
        protected string color;
        protected double speed;

        public abstract void GetCarData();
        public virtual void DisplayCarData()
        {
            Console.WriteLine("Car details are:");
            Console.WriteLine("Car model no. is:" + this.modelNo);
            Console.WriteLine("Car make is:" + this.make);
            Console.WriteLine("Car color no. is:" + this.color);
            Console.WriteLine("Car speed no. is:" + this.speed);
        }
    }
    class Vehicle : Car
    {
        int year, seat;
        public override void GetCarData()
        {
            Console.WriteLine("Enter car details:");
            this.modelNo = Convert.ToInt32(Console.ReadLine());
            this.make = Console.ReadLine();
            this.color = Console.ReadLine();
            this.speed = Convert.ToDouble(Console.ReadLine());
            this.year = Convert.ToInt32(Console.ReadLine());
            this.seat = Convert.ToInt32(Console.ReadLine());
        }
        public override void DisplayCarData()
        {
            Console.WriteLine("Car details are:");
            Console.WriteLine("Car model no. is:" + this.modelNo);
            Console.WriteLine("Car make is:" + this.make);
            Console.WriteLine("Car color no. is:" + this.color);
            Console.WriteLine("Car speed no. is:" + this.speed);
            Console.WriteLine("Car year no. is:" + this.year);
            Console.WriteLine("Car seat no. is:" + this.seat);
        }
    }
    class AbstractImplement
    {
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();
            veh.GetCarData();
            veh.DisplayCarData();
            Console.ReadKey(); 
        }
    }
}
