using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.IngredientsRepositories
{
    public interface IIngredientRepository : IGenericRepository<Ingredient>
    {
        Task<List<Ingredient>> GetAllIngredients();
        Task<List<Ingredient>> GetAllByName(string name);


    }
}
