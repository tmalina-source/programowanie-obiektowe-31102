namespace Projekt_MagazynKamieniSzlachetnych
{
    public class InorganicGem_Instance
    {
       
        public GemCategory_Origin Origin { get; set; }
        public bool Polished { get; set; }
        public bool InclusionsPresent { get; set; }
        public float Size { get; set; }

        public float Value { get; set; }

        public InorganicGem_Type Gem_Type { get; set; }
        public InorganicGem_Instance(bool polished, bool inclusionsPresent, float size, float value, GemCategory_Origin origin, InorganicGem_Type gem_type)
        {
            Origin = origin;
            Polished = polished;
            InclusionsPresent = inclusionsPresent;
            Size = size;  
            Value = value;
            Gem_Type = gem_type;
        }
        public string getOriginString()
        {
            return Origin.ToString();
        }


    }

}
