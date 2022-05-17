using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.CommentRepositories
{
    public class CommentRepository: GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext context) : base(context) { }
        public async Task<List<Comment>> GetAllComments()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment> GetCommentById(int id)
        {
            return await _context.Comments.Where(a => a.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
