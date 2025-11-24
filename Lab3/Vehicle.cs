using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Vehicle
    {
        public double EngineCapacity { get; protected set; }
        public string model;
        public int year;
        public string Model => model;
        public int Year
        {
            get { return year; }
        }
        public virtual void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
        public Vehicle(double engineCapacity, string model, int year)
        {
            EngineCapacity = engineCapacity;
            this.model = model;
            this.year = year;
        }
        public void ShowMe()
        {
            Console.WriteLine($"Model: {Model}, Year: {Year}, Engine Capacity: {EngineCapacity}");
        }
        abstract public void Test();  //abstract methods basically force "children"/inheritors to have a method of the same name. They can't have a "body", so using {} brackets is a no-no



    }
}
