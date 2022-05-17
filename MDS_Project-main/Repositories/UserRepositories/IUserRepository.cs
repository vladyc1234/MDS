using RecipesApp.Entities;
using RecipesApp.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories.UserRepositories
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByEmail(string email);
        Task<User> GetByIdWithRoles(int id);

        Task<User> GetUserById(int id);
    }
    
}

