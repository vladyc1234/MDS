using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.QuestionsRepositories
{
     public interface IQuestionRepository :  IGenericRepository<Question>
    {
        Task<List<Question>> GetAllQuestions();
        Task<Question> GetQuestionById(int id);
    }
}
