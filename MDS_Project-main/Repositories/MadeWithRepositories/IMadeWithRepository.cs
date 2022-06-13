using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.MadeWithRepositories
{
    public interface IMadeWithRepository : IGenericRepository<MadeWith>
    {
        Task<List<MadeWith>> GetAllMadeWith();
        Task<MadeWith> GetMadeWithById(int idRecipe);
    }
}
