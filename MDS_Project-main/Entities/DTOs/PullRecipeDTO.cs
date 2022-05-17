using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class PullRecipeDTO
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int IdRecipe { get; set; }
        public Recipe Recipe { get; set; }
    
        public PullRecipeDTO(PullRecipe pullrecipe)
        {
            this.Id = pullrecipe.Id;
            this.CreationDate = pullrecipe.CreationDate;
            this.IdRecipe = pullrecipe.IdRecipe;
            this.Recipe = pullrecipe.Recipe;
        }
    }
}
