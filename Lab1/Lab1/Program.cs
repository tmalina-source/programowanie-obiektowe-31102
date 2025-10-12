//Zad2
int number = 0;
do
{
    Console.Write("Enter number: ");
    string numberstring = Console.ReadLine();
    bool success = int.TryParse(numberstring, out number);

    if (!success)
    {
        Console.WriteLine("Provide an actual number");
    }
}
while (number <= 0);

//Zad1
/*
const string correctPassword = "admin123";
string password;
do
{
    Console.Write("Enter password: ");
    password = Console.ReadLine();
}
while (password != correctPassword);
Console.WriteLine("Succesfully loggen in!");
*/
//Początek lekcji
/*
const int requiredAgePartial = 14;
const int requiredAgeFull = 18;
const string accessDeniedMessage ="Access denied, You must be at least 14 years old for partial access or at least 18 for full access";
const string accessAllowedPartial = "Partial access granted";
const string accessAllowedFull = "Full access granted";

int age;
Console.WriteLine("Podaj swój wiek: ");

string input = Console.ReadLine();

bool success = int.TryParse(input, out age);

if (!success)
{
    Console.WriteLine("Podaj poprawną wartość!");
}
else
{
    if (age >= requiredAgeFull)
    {
        Console.WriteLine(accessAllowedFull);
    }
    else if (age >= requiredAgePartial)
    {
        Console.WriteLine(accessAllowedPartial);
    }
    else
    {
        Console.WriteLine(accessDeniedMessage);
    }
}
*/