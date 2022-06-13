using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.RecipeLibraryRepositories
{
    public interface IRecipeLibraryRepository : IGenericRepository<RecipeLibrary>
    {
        Task<List<RecipeLibrary>> GetAllRecipeLibrary();
        Task<RecipeLibrary> GetRecipeLibraryById(int idRecipe);
    }
}
