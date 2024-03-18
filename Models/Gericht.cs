namespace FoodLibrary.Models
{
    public class Gericht
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required ICollection<GerichtKomponente> GerichtKomponenten { get; set; }
    }
}
