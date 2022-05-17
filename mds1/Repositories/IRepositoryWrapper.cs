using RecipesApp.Repositories.IngredientsRepositories;
using RecipesApp.Repositories.RecipeRepositories;
using RecipesApp.Repositories.SessionTokenRepositories;
using RecipesApp.Repositories.TagRepositories;
using RecipesApp.Repositories.UserRepositories;
using RecipesApp.Repositories.UtensilRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IUtensilRepository Utensil { get; }
        ITagRepository Tag { get; }
        IRecipeRepository Recipe { get; }
        IIngredientRepository Ingredient { get; }
        ISessionTokenRepository SessionToken { get; }

        Task SaveAsync();
    }
}
