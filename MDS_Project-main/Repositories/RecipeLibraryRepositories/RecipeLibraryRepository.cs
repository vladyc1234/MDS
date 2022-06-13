using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.RecipeLibraryRepositories
{
    public class RecipeLibraryRepository : GenericRepository<RecipeLibrary>, IRecipeLibraryRepository
    {
        public RecipeLibraryRepository(AppDbContext context) : base(context) { }
        public async Task<List<RecipeLibrary>> GetAllRecipeLibrary()
        {
            return await _context.RecipeLibraries.ToListAsync();
        }

        public async Task<RecipeLibrary> GetRecipeLibraryById(int idRecipe)
        {
            return await _context.RecipeLibraries.Where(a => a.IdRecipe.Equals(idRecipe)).FirstOrDefaultAsync();
        }
    }
}
