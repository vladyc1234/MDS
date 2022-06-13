using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.DerivedRecipeRepositories
{
    public class DerivedRecipeRepository : GenericRepository<DerivedRecipe>, IDerivedRecipeRepository
    {
        public DerivedRecipeRepository(AppDbContext context) : base(context) { }


        public async Task<List<DerivedRecipe>> GetAllDerivedRecipes()
        {
            return await _context.DerivedRecipes.ToListAsync();
        }
        public async Task<DerivedRecipe> GetDerivedRecipeById(int id)
        {
            return await _context.DerivedRecipes.Where(a => a.Id.Equals(id)).FirstOrDefaultAsync();
        }
        public async Task<List<DerivedRecipe>> GetAllDerivedRecipesByName(string name)
        {
            return await _context.DerivedRecipes.Where(a => a.Name.Equals(name)).ToListAsync();
        }
    }
}
