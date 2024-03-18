namespace FoodLibrary.Models
{
    public class KomponenteZutat
    {
        public int KomponenteID { get; set; }
        public required Komponente Komponente { get; set; }

        public int ZutatID { get; set;}
        public required Zutat Zutat { get; set;}
    }
}
