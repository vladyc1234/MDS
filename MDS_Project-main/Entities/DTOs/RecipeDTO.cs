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
        public int Rating { get; set; }
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
            this.Rating = recipe.Rating;

            this.User = recipe.User;
            this.PullRecipes = recipe.PullRecipes.ToList();
            this.Reviews = recipe.Reviews.ToList();
            this.Comments = recipe.Comments.ToList();
            this.Questions = recipe.Questions.ToList();
            this.DerivedRecipes = recipe.DerivedRecipes.ToList();
            this.MadeWiths = recipe.MadeWiths.ToList();
            this.CookedWiths = recipe.CookedWiths.ToList();
            this.RecipeTags = recipe.RecipeTags.ToList();
            this.RecipeLibraries = recipe.RecipeLibraries.ToList();
        }

        public static implicit operator RecipeDTO(ReviewDTO v)
        {
            throw new NotImplementedException();
        }
    }
}
