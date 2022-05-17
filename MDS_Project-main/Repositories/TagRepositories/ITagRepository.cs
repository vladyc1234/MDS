using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.TagRepositories
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        Task<List<Tag>> GetAllTags();
        Task<List<Tag>> GetAllByName(string name);

    }
}
