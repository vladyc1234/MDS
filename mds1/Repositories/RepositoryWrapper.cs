using RecipesApp.Data;
using RecipesApp.Repositories.IngredientsRepositories;
using RecipesApp.Repositories.RecipeRepositories;
using RecipesApp.Repositories.SessionTokenRepositories;
using RecipesApp.Repositories.TagRepositories;
using RecipesApp.Repositories.UserRepositories;
using RecipesApp.Repositories.UtensilRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _context;
        
        private IUserRepository _user;
        private IUtensilRepository _utensil;
        private ITagRepository _tag;
        private IRecipeRepository _recipe;
        private IIngredientRepository _ingredient;
        private ISessionTokenRepository _sessionToken;


        public RepositoryWrapper(AppDbContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;
            }
        }

        public IUtensilRepository Utensil
        {
            get
            {
                if (_utensil == null) _utensil = new UtensilRepository(_context);
                return _utensil;
            }
        }

        public ITagRepository Tag
        {
            get
            {
                if (_tag == null) _tag = new TagRepository(_context);
                return _tag;
            }
        }
        public IRecipeRepository Recipe
        {
            get
            {
                if (_recipe == null) _recipe = new RecipeRepository(_context);
                return _recipe;
            }
        }

        public IIngredientRepository Ingredient
        {
            get
            {
                if (_ingredient == null) _ingredient = new IngredientsRepository(_context);
                return _ingredient;
            }
        }
        public ISessionTokenRepository SessionToken
        {
            get
            {
                if (_sessionToken == null) _sessionToken = new SessionTokenRepository(_context);
                return _sessionToken;
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
