using Lab3;
using System.Runtime.CompilerServices;
/*
Console.WriteLine("a");
Car car1 = new Car("Audi", 2023, 3.6);
Car car2 = new Car("VM", 1998, 2.0);
Car car3 = new Car("Fiat", 2011, 1.4);
car1.Start();
*/
//Car car3 = new Car(1.4, "Fiat", 2011);
//car3.ShowMe();

//Console.WriteLine("a");

//Car car1 = new Car();
bool shopActive = true;
while (shopActive == true)
{
    Console.WriteLine("CAR SHOP");
    Console.WriteLine("[0] Exit, [1] Show all, [2]");
    Console.WriteLine("");
    var input = Console.ReadKey().KeyChar;
    Console.WriteLine("");
    switch (input)
    {
        case '0':
            Console.WriteLine("Goodbye");
            shopActive = false;
            break;
        case '1': //gotta use '' instead of "", the first is for characters, the second's for strings
            Console.WriteLine("Our vehicles:");
            foreach (var vehicle in Database.Vehicles)
            {
                vehicle.ShowMe();
            }
            break;
    }
}
