using Microsoft.EntityFrameworkCore;
using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.ReviewsRepositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext context) : base(context) { }
        public async Task<List<Review>> GetAllReviews()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review> GetReviewById(int id)
        {
            return await _context.Reviews.Where(a => a.Id.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
