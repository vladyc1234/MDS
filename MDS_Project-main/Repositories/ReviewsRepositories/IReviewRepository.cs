using RecipesApp.Data;
using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.ReviewsRepositories
{
    public interface IReviewRepository: IGenericRepository<Review>
    {
        Task<List<Review>> GetAllReviews();
        Task<Review> GetReviewById(int id);
    }
}
