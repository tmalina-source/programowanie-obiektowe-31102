using Lab3;
using System.Reflection;
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
    Console.WriteLine("[0] Exit, [1] Show all, [2] Search by year, [3] Search by model, [4] Search by engine capacity , [5] Add Vehicle");
    // HOMEWORK:
    //3: Search by model, make it get accepted regarded of case, so BMV = bMV = BmV etc. [done]
    //4: Search by engine capacity [done]
    var input = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (input)
    {
        case '0':
            Console.WriteLine("Goodbye");
            shopActive = false;
            break;
        case '1': //gotta use '' instead of "", the first is for characters, the second's for strings
            ShowAll();
            break;
        case '2':
            SearchByYear();
            break;
        case '3':
            SearchByModel();
            break;
        case '4':
            SearchByEngineCapacity();
            break;
        case '5':
            AddNewVehicle();
            break;
        default:
            Console.WriteLine("invalid option");
            break;
    }
}

void ShowAll()
{
    Console.WriteLine("Our vehicles:");
    foreach (var vehicle in Database.Vehicles)
    {
        vehicle.ShowMe();
    }
}
void SearchByYear()
{
    Console.WriteLine("Enter year: ");
    if (Int32.TryParse(Console.ReadLine(), out int year))
    {
        var validVehicles = Database.Vehicles.Where(vehicle => vehicle.year == year);
        if (validVehicles.Any())
        {


            foreach (var vehicle in validVehicles)
            {
                vehicle.ShowMe();
            }
        }
        else
        {
            Console.WriteLine("No vehicles matching the provided year found, restarting");
        }


    }
    else
    {
        Console.WriteLine("Invalid year, try again");
        SearchByYear();
    }
}

void SearchByEngineCapacity()
{
    Console.WriteLine("Enter engine capacity: ");
    if (double.TryParse(Console.ReadLine(), out double capacity))
    {
        var validVehicles = Database.Vehicles.Where(vehicle => vehicle.EngineCapacity == capacity);
        if (validVehicles.Any())
        {


            foreach (var vehicle in validVehicles)
            {
                vehicle.ShowMe();
            }
        }
        else
        {
            Console.WriteLine("No vehicles matching the provided capacity found, restarting");
        }


    }
    else
    {
        Console.WriteLine("Invalid capacity, try again");
        SearchByEngineCapacity();
    }
}

void SearchByModel()
{
    Console.WriteLine("Enter car model: ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid model, try again");
        return;
    }

    var validVehicles = Database.Vehicles.Where(vehicle => vehicle.model.ToLower() == input.ToLower());
    if (validVehicles.Any())
    {


        foreach (var vehicle in validVehicles)
        {
            vehicle.ShowMe();
        }
    }
    else
    {
        Console.WriteLine("No vehicles matching the provided model found, restarting");
    }



}

void AddNewVehicle()
{
    Console.WriteLine("B for bike, C for car");
    var input = Console.ReadKey().KeyChar;
    //  if (input.ToString().ToLower()!="b"&& input.ToString().ToLower() != "c")
    if (input.ToString().ToLower() is not ("b" or "c"))
    {
        Console.WriteLine("Invalid vehicle type");
        return;
    }
    Console.WriteLine();
    Console.WriteLine("Provide engine capacity");
    bool correctlyParsed = double.TryParse(Console.ReadLine(), out double engineCapacity);

    if (!correctlyParsed)
    {
        Console.WriteLine("Invalid engine capacity");
        return;
    }
    Console.WriteLine("Provide year");
    correctlyParsed = int.TryParse(Console.ReadLine(), out int year);
    if (!correctlyParsed)
    {
        Console.WriteLine("Invalid year");
        return;
    }
    Console.WriteLine("Provide model");
    string? model = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(model))
    {
        Console.WriteLine("Invalid model");
        return;
    }

    Vehicle? v = null;
    switch (input.ToString().ToLower())
    {
        case "b":
            v = new Bike(engineCapacity, model, year);

            break;
        case "c":
            v = new Car(engineCapacity, model, year);

            break;

    }
    if (v != null)
    {
        Database.Vehicles.Add(v);
    }

}
