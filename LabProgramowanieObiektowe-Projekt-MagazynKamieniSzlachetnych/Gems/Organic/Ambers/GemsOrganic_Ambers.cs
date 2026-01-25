
namespace Projekt_MagazynKamieniSzlachetnych
{
    public class OrganicGem_Ambers : Stone
    {

       // public GemCategory_Preciousness Preciousness { get; set; }
        public bool Polished { get; set; }
        public bool InclusionsPresent { get; set; }

        public int AmberClass { get; set; }

        public float Size { get; set; }

        public float Value { get; set; }
        public OrganicGem_Ambers(string color, double hardness, string gemName, bool polished, bool inclusionsPresent, int amberClass, float size, float value) : base(color, hardness, gemName)
        {
            // Preciousness = preciousness;
            Polished = polished;
            InclusionsPresent = inclusionsPresent;
            AmberClass = amberClass;
            Size = size;
            Value = value;
          
        }
        /*
        public string getPreciousnessString()
        {
            if (Preciousness == GemCategory_Preciousness.Precious)
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
        */

    }

}
