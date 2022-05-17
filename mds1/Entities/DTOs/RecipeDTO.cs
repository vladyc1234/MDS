using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RecipeFinal { get; set; }
        public DateTime CreationDate { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public List<PullRecipe> PullRecipes { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Question> Questions { get; set; }
        public List<DerivedRecipe> DerivedRecipes { get; set; }
        public List<MadeWith> MadeWiths { get; set; }
        public List<CookedWith> CookedWiths { get; set; }
        public List<RecipeTag> RecipeTags { get; set; }
        public List<RecipeLibrary> RecipeLibraries { get; set; }

        public RecipeDTO(Recipe recipe)
        {
            this.Id = recipe.Id;
            this.Name = recipe.Name;
            this.RecipeFinal = recipe.RecipeFinal;
            this.CreationDate = recipe.CreationDate;
            this.IdUser = recipe.IdUser;
            this.User = recipe.User;
            this.PullRecipes = new List<PullRecipe>();
            this.Reviews = new List<Review>();
            this.Comments = new List<Comment>();
            this.Questions = new List<Question>();
            this.DerivedRecipes = new List<DerivedRecipe>();
            this.MadeWiths = new List<MadeWith>();
            this.CookedWiths = new List<CookedWith>();
            this.RecipeTags = new List<RecipeTag>();
            this.RecipeLibraries = new List<RecipeLibrary>();
        }
    }
}
