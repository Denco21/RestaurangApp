namespace Restaurang.Models
{
    public class Drink
    {
     public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; } = "~/Images/ColaZero.jpg"; 
        public int CategoryId { get; set; }

    }
}
