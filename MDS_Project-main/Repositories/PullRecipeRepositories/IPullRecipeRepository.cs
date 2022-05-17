using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.PullRecipeRepositories
{
    public interface IPullRecipeRepository : IGenericRepository<PullRecipe>
    {
        Task<List<PullRecipe>> GetAllPullRecipes();
        Task<PullRecipe> GetPullRecipeById(int id);
    }
}
