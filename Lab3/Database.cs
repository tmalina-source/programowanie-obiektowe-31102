using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Database
    {

        public static List<Vehicle> Vehicles { get; set; } =
            [
            new Bike(0.75,"Yamaha", 2025),
            new Bike(0.94,"Arch", 2077),
             new Car(1.28,"Delamain", 2077),
              new Car(2.56,"VM", 2025),
             new Car(1.28,"Yamaha", 2026),
            ];
        public void AddVehicle (Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

    }
}
