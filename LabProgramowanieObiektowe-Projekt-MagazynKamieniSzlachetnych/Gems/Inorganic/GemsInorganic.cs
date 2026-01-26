
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Projekt_MagazynKamieniSzlachetnych
{
    public class InorganicGem_Type : Stone
    {
        public override string getPageAddress()
        {
            return "geminst_io";
        }
        public GemCategory_Preciousness Preciousness { get; set; }

        public InorganicGem_Type(string color, double hardness, string gemName, GemCategory_Preciousness preciousness) : base(color, hardness, gemName)
        {
            Preciousness = preciousness;
        }
        public bool anyInstancesOfThisSpecies()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter() }
            };
            var GemInstancesOfThisSpecies = JsonSerializer.Deserialize<List<InorganicGem_Instance>>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Gems_Inorganic_Instances.json")), options).Where(GemInstance => GemInstance.Gem_Type == this);
            if (GemInstancesOfThisSpecies.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
          
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
