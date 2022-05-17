using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.IngredientsRepositories
{
    public class IngredientsRepository : GenericRepository<Ingredient>, IIngredientRepository
    {
        public IngredientsRepository(AppDbContext context) : base(context) { }


        public async Task<IEnumerable<Ingredient>> GetAllIngredientsAsync()
        {
            return await _context.Ingredients.ToArrayAsync();
        }

        public async Task<List<Ingredient>> GetAllByName(string name)
        {
            return await _context.Ingredients.Where(a => a.Name == name).ToListAsync(); ;
        }
    }
}
