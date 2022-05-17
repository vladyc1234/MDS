using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class IngredientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public List<MadeWith> MadeWiths { get; set; }

        public IngredientDTO(Ingredient ingredient)
        {
            this.Id = ingredient.Id;
            this.Name = ingredient.Name;
            this.Price = ingredient.Price;
            this.MadeWiths = new List<MadeWith>();
        }
    }
}
