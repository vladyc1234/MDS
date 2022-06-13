using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.RecipeTagRepositories
{
    public interface IRecipeTagRepository : IGenericRepository<RecipeTag>
    {
        Task<List<RecipeTag>> GetAllRecipeTag();
        Task<RecipeTag> GetRecipeTagById(int idRecipe);
    }
}
