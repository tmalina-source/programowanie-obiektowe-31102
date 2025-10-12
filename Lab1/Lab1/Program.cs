//Zad4
Osoba osoba1 = new Osoba("Paweł", 21);
Osoba osoba2 = new Osoba("Elżbieta", 195);
Osoba osoba3 = new Osoba("CK-195B", -210);
Osoba[] osoby = {osoba1, osoba2, osoba3};
foreach (var osoba in osoby)
{
    osoba.PrzedstawSie();
}
class Osoba
{
   
    public string Imie { get; set; }
    public int Wiek { get; set; }
    public Osoba(string imie, int wiek)
    {
        Imie = imie;
        Wiek = wiek;
    }
    public void PrzedstawSie()
    {
        Console.WriteLine($"Witam, mam na imię {Imie} i mam {Wiek} lat!");
    }
}


//Zad3
/*
string[] miasta = { "Jarocin", "Krotoszyn", "Koźmin", "Poznań", "Warszawa" };
foreach (var miasto in miasta)
{
    Console.WriteLine($"\n {miasto}");
}
*/


//Zad2

/*
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
*/

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