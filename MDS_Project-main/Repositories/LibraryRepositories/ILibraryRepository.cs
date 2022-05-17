using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.LibraryRepositories
{
    public interface ILibraryRepository : IGenericRepository<Library>
    {
        Task<List<Library>> GetAllLibrarys();
        Task<Library> GetLibraryById(int id);
    }
}
