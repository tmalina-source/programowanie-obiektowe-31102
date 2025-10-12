//Zad 6

using System.Security.Cryptography.X509Certificates;

class Zwierze
{
  public void Jedz() => Console.WriteLine("Zwierzę je");
}
class Pies : Zwierze
{
  public void Szczekaj() => Console.WriteLine("Hau hau!");
}
class Kot : Zwierze
{
  public void Miaucz() => Console.WrtiteLine("Miau miau!");
}

//Zad 5
/*
class KontoBankowe
{
  private double saldo;
  public void Wplata(double kwota) { saldo += kwota; }
  public double PobierzSaldo() { return saldo; }

  public void Wyplata(double kwota)
  {
    if (kwota > saldo)
    {
      Console.Write("Insufficient funds");
    }
    else
    {
      saldo+= kwota;
    }
  }
}
*/
/*
Car car1 = new Car("Audi",2023);
Car car2 = new Car("VW",1998);  
Car car3 = new Car("Fiat",2011);

car1.ShowMe();
car2.ShowMe();
car3.ShowMe();
//car1.model = "test";
class Car
{
  private string model;
  private int year;

  public string Model
  {
    get { return model; }
    //set { model = value; }
  }

  public int Year
  {
    get { return year; }
   // set if (value < 2000)
   // {
   // throw new Exception("Your car is too old"); 
  //}
  }
  
  public Car(string model, int year)
  {
    this.model=model;
    this.year=year;
  }

  public void ShowMe()
  {
    Console.WriteLine($"Model: {model}");
    Console.WriteLine($"Year: {year}");
  }
}
*/