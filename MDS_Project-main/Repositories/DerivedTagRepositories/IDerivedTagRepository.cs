using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.DerivedTagRepositories
{
   public interface IDerivedTagRepository : IGenericRepository<DerivedTag>
    {
        Task<List<DerivedTag>> GetAllDerivedTag();
        Task<DerivedTag> GetDerivedTagById(int idRecipe);
    }
}
