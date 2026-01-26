
namespace Projekt_MagazynKamieniSzlachetnych
{
    public class OrganicGem_Pearls : Stone
    {


        public override string getPageAddress()
        {
            return "gem_o_pearl";
        }

        public float Size { get; set; }
        public float Value { get; set; }

        public PearlCategory_Shape PearlShape { get; set; }
        public PearlCategory_Surface PearlSurface { get; set; }
        public PearlCategory_Luster PearlLuster { get; set; }



        public OrganicGem_Pearls(string color, double hardness, string gemName, float size, float value, PearlCategory_Shape pearlShape, PearlCategory_Surface pearlSurface, PearlCategory_Luster pearlLuster) : base(color, hardness, gemName)
        {

            PearlShape = pearlShape;
            PearlLuster = pearlLuster;
            PearlSurface = pearlSurface;
            Size = size;
            Value = value;
            base.Hardness = 2.5;


        }
        public string getShapeString()
        {
            if (PearlShape == PearlCategory_Shape.NearRound)
            {
                return "Near Round";
            }
            if (PearlShape == PearlCategory_Shape.SemiBoroque)
            {
                return "Semi-Boroque";
            }
            else
            {
                return this.PearlShape.ToString();
            }

        }
        public string getSurfaceString()
        {
            if (PearlSurface == PearlCategory_Surface.LightlySpotted)
            {
                return "Lightly Spotted";
            }
            if (PearlSurface == PearlCategory_Surface.HeavilySpotted)
            {
                return "Heavily Spotted";
            }
            if (PearlSurface == PearlCategory_Surface.ModeratelySpotted)
            {
                return "Moderately Spotted";
            }
            return this.PearlSurface.ToString();
        }
        public string getLusterString()
        {
            if (PearlLuster == PearlCategory_Luster.VeryGood)
            {
                return "Very Good";
            }
            else
            {
                return this.PearlLuster.ToString();
            }

        }


    }

}
