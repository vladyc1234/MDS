using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.UtensilRepositories
{
    public interface IUtensilRepository : IGenericRepository<Utensil>
    {
        Task<IEnumerable<Utensil>> GetAllUtensilsAsync();
        Task<List<Utensil>> GetAllByName(string name);
    }
}
