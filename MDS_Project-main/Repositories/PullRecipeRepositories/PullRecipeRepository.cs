using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.PullRecipeRepositories
{
    public class PullRecipeRepository : GenericRepository<PullRecipe>, IPullRecipeRepository
    {
        public PullRecipeRepository(AppDbContext context) : base(context) { }
        public async Task<List<PullRecipe>> GetAllPullRecipes()
        {
            return await _context.PullRecipes.ToListAsync();
        }

        public async Task<PullRecipe> GetPullRecipeById(int id)
        {
            return await _context.PullRecipes.Where(a => a.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
