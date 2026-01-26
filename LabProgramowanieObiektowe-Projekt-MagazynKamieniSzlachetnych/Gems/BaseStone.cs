using System.Drawing;

namespace Projekt_MagazynKamieniSzlachetnych
{
    public abstract class Stone
    {


        public abstract string getPageAddress();
       
        public string Color { get; set; } //they gotta be public
       // public float Value { get; set; } case-by-case basis, this will be for "instances"
        //public string ChemicalMakeUp { get; set; }
        public double Hardness { get; set; }
    
        public string GemName { get; set; }


        public Stone(string color, double hardness, string gemName)
        {
         
          
            this.Color = color;
           // this.ChemicalMakeUp = chemicalMakeUp;
            this.Hardness = hardness;
            //this.Toughness = toughness;
            this.GemName = gemName;

        }
       
    }
}
