using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.CookedWithRepositories
{
    public interface ICookedWithRepository : IGenericRepository<CookedWith>
    {
        Task<List<CookedWith>> GetAllCookedWith();
        Task<CookedWith> GetCookedWithById(int idRecipe);
    }
}
