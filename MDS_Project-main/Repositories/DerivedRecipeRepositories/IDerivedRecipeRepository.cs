using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.DerivedRecipeRepositories
{
    public interface IDerivedRecipeRepository : IGenericRepository<DerivedRecipe>
    {
            Task<List<DerivedRecipe>> GetAllDerivedRecipes();
            Task<DerivedRecipe> GetDerivedRecipeById(int id);
            Task<List<DerivedRecipe>> GetAllDerivedRecipesByName(string name);
    }
}
