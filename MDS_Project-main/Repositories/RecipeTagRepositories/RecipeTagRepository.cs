using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.RecipeTagRepositories
{
    public class RecipeTagRepository : GenericRepository<RecipeTag>, IRecipeTagRepository
    {
        public RecipeTagRepository(AppDbContext context) : base(context) { }
        public async Task<List<RecipeTag>> GetAllRecipeTag()
        {
            return await _context.RecipeTags.ToListAsync();
        }

        public async Task<RecipeTag> GetRecipeTagById(int idRecipe)
        {
            return await _context.RecipeTags.Where(a => a.IdRecipe.Equals(idRecipe)).FirstOrDefaultAsync();
        }
    }
}
