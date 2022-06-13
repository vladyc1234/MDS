using RecipesApp.Repositories.CommentRepositories;
using RecipesApp.Repositories.CookedWithRepositories;
using RecipesApp.Repositories.DerivedTagRepositories;
using RecipesApp.Repositories.IngredientsRepositories;
using RecipesApp.Repositories.LibraryRepositories;
using RecipesApp.Repositories.MadeWithRepositories;
using RecipesApp.Repositories.QuestionsRepositories;
using RecipesApp.Repositories.RecipeLibraryRepositories;
using RecipesApp.Repositories.RecipeRepositories;
using RecipesApp.Repositories.RecipeTagRepositories;
using RecipesApp.Repositories.ReviewsRepositories;
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
        ILibraryRepository Library { get; }
        IRecipeTagRepository RecipeTag { get; }
        IDerivedTagRepository DerivedTag { get; }
        IRecipeLibraryRepository RecipeLibrary { get; }
        IMadeWithRepository MadeWith { get; }
        ICookedWithRepository CookedWith { get; }

        IQuestionRepository Question { get; }
        IReviewRepository Review{ get; }
        ICommentRepository Comment { get; }
        IUtensilRepository Utensil { get; }
        ITagRepository Tag { get; }
        IRecipeRepository Recipe { get; }
        IIngredientRepository Ingredient { get; }
        ISessionTokenRepository SessionToken { get; }

        Task SaveAsync();
    }
}
