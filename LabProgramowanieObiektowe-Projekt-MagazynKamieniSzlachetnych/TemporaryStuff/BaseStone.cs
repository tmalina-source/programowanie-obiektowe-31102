using System.Drawing;

namespace LabProjekt
{
    public abstract class Stone
    {
        // public string color;
        // public float value;

        /* public double engineCapacity;
         public string model;
         public int year;

         private Color colorValue;
         private string color;
         private float value;
         private string chemicalMakeUP;
         private int hardness;
         private int toughness;
         private string gemName;*/

        /*
          public Stone(string color, Color colorValue, float value, string chemicalMakeUP, int hardness, int toughness, string Gemname)
        {
            
            this.colorValue = colorValue;
            this.color = color;
            this.value = value;
            this.chemicalMakeUP = chemicalMakeUP;
            this.hardness = hardness;
            this.toughness = toughness;
            this.gemName = gemName;
        }
        public Stone(string color, float value)
        {
            this.color = color;
            this.value = value;

        }
        public Stone(double engineCapacity, string model, int year)
        {
            this.engineCapacity = engineCapacity;
            this.model = model;
            this.year = year;
        }*/

        //  public double EngineCapacity { get; set; }
        //  public string Model { get; set; }
        //  public int Year { get; set; }

        public Color ColorValue { get; set; } 
        public string Color { get; set; } //they gotta be public
       // public float Value { get; set; } case-by-case basis, this will be for "instances"
        public string ChemicalMakeUp { get; set; }
        public int Hardness { get; set; }
        public int Toughness { get; set; }
        public string GemName { get; set; }


        public Stone(Color colorValue, string color, string chemicalMakeUp, int hardness, int toughness, string gemName)
        {
         
          this.ColorValue = colorValue;
            this.Color = color;
            this.ChemicalMakeUp = chemicalMakeUp;
            this.Hardness = hardness;
            this.Toughness = toughness;
            this.GemName = gemName;

        }
       
    }
}
