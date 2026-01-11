using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bike : Vehicle
    {
        public Bike(double engineCapacity, string model, int year) : base(engineCapacity, model, year)
        {

        }
        public override void Start()
        {
            Console.WriteLine("Bike started");
        }
        public override void Stop()
        {
            Console.WriteLine("Bike stopped");
        }
        public override void Test()
        {
            Console.WriteLine("Bike did a test of some kind");
        }
    }
}
