
namespace Projekt_MagazynKamieniSzlachetnych
{
    public class InorganicGem_Type : Stone
    {
       
        public GemCategory_Preciousness Preciousness { get; set; }
       
        public InorganicGem_Type(string color, double hardness, string gemName, GemCategory_Preciousness preciousness) : base(color, hardness, gemName)
        {
            Preciousness = preciousness;
        }
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
     
      
    }
   
}
