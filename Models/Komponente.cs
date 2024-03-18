namespace FoodLibrary.Models
{
    public class Komponente
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required ICollection<KomponenteZutat> KomponenteZutaten { get; set; }
    }
}
