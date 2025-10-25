namespace Server.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<Ingredient> Ingredients { get; set; } = new();
        public int TotalProtein { get; set; }
        public int TotalCalories { get; set; }
    }

    public class Ingredient
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }

        public decimal Weight { get; set; }
        public string Name { get; set; } = "";
        public string Comment { get; set; } = "";
        public int FdcId { get; set; }
    }
}
