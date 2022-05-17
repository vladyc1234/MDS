using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.CommentRepositories
{
    public interface ICommentRepository: IGenericRepository<Comment>
    {
        Task<List<Comment>> GetAllComments();
        Task<Comment> GetCommentById(int id);
    }
   
}
