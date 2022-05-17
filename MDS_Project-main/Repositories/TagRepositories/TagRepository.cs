using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.TagRepositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context) { }

        public async Task<List<Tag>> GetAllTags()
        {
            return await _context.Tags.ToListAsync();

        }

        public async  Task<List<Tag>> GetAllByName(string name)
        {
            return await _context.Tags.Where(a => a.Name == name).ToListAsync(); ;
        }
    }
}
