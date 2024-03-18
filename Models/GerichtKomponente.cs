namespace FoodLibrary.Models
{
    public class GerichtKomponente
    {
        public int GerichtID { get; set; }
        public required Gericht Gericht { get; set; }

        public int KomponenteID { get; set; }
        public required Komponente Komponente { get; set; }
    }
}
