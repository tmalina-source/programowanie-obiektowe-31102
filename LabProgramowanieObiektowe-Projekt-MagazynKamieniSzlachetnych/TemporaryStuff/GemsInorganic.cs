
using System.Drawing;

namespace LabProjekt
{
    public class InorganicGem_Type : Stone
    {
        // public float size;
        // private GemCategory_Preciousness preciousness;
        // private GemCategory_Origin origin;
        // private bool polished;
        // private bool inclusionsPresent;
        /*
        private Color colorValue;
        private string color;
        private float value;
        private string chemicalMakeUP;
        private int hardness;
        private int toughness;
       public Stone(string color, Color colorValue, float value, string chemicalMakeUP, int hardness, int toughness)
        {
            this.colorValue = colorValue;
            this.color = color;
            this.value = value;
            this.chemicalMakeUP = chemicalMakeUP;
            this.hardness = hardness;
            this.toughness = toughness;

        }
        
          public Car(double engineCapacity, string model, int year) : base(engineCapacity, model, year)
        {
            
        }
       
       
       
       */

        /*  public InorganicGem(string color, Color colorValue, float value, string chemicalMakeUP, int hardness, int toughness, float size, string gemName, GemCategory_Preciousness preciousness, GemCategory_Origin origin, bool polished, bool inclusionsPresent) : base(color, colorValue, value, chemicalMakeUP, hardness, toughness, gemName)
        {
            this.size = size;
           // this.preciousness = preciousness;
           // this.origin = origin;
           // this.inclusionsPresent = inclusionsPresent;
            // this.polished = polished;
        }*/
        // public InorganicGem(string color, float value) : base(color, value)
        // {
        // this.size = size;
        // this.preciousness = preciousness;
        // this.origin = origin;
        // this.inclusionsPresent = inclusionsPresent;
        // this.polished = polished;
        //  }
      //  public string GemName { get; set; }
        // public float size; for instances
        public GemCategory_Preciousness Preciousness { get; set; }
        // private GemCategory_Origin origin; for instances
        // private bool polished; for instances
        // private bool inclusionsPresent; for instances
        public InorganicGem_Type(string color, string chemicalMakeUP, double hardness, string gemName, GemCategory_Preciousness preciousness) : base(color, chemicalMakeUP, hardness, gemName)
        {
            this.Preciousness = preciousness;
        }
        public string getPreciousnessString()
        {
            if (this.Preciousness== GemCategory_Preciousness.Precious)
            {
                return "Precious";
            }
            else
            {
                return "Semi-Precious";
            }
               // return this.Preciousness.ToString();
               //Enums don't appreciate "-", apparently
        }
     
      
    }
   
}
