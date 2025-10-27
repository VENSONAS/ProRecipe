using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace Server.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<Ingredient> Ingredients { get; set; } = new();
    }

    public class Ingredient
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string Name { get; set; } = "";
        public string Comment { get; set; } = "";
        public decimal Weight { get; set; }
        public decimal ProteinPer100 { get; set; }
        public decimal CaloriePer100 { get; set; }
        public int FdcId { get; set; }
    }
}
