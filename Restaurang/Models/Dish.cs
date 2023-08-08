namespace Restaurang.Models
{
	public class Dish
	{
		public int Id { get; set; } 
		public string Name { get; set; } 
		public string? Ingredients { get; set; } 
		public string Description { get; set; } 
		public decimal Price { get; set; }
		public string Image { get; set; } = "~/Images/Pizza.jpg";
		public int CategoryId { get; set; }
		
	}
}
