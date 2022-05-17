using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.LibraryRepositories
{
    public class LibraryRepository : GenericRepository<Library>, ILibraryRepository
    {
        public LibraryRepository(AppDbContext context) : base(context) { }
        public async Task<List<Library>> GetAllLibrarys()
        {
            return await _context.Libraries.ToListAsync();
        }

        public async Task<Library> GetLibraryById(int id)
        {
            return await _context.Libraries.Where(a => a.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
