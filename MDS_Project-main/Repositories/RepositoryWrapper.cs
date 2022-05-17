using RecipesApp.Data;
using RecipesApp.Repositories.CommentRepositories;
using RecipesApp.Repositories.IngredientsRepositories;
using RecipesApp.Repositories.LibraryRepositories;
using RecipesApp.Repositories.PullRecipeRepositories;
using RecipesApp.Repositories.QuestionsRepositories;
using RecipesApp.Repositories.RecipeRepositories;
using RecipesApp.Repositories.ReviewsRepositories;
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
        private IPullRecipeRepository _pull;
        private ILibraryRepository _library;
        private IQuestionRepository _question;
        private IReviewRepository _review;
        private ICommentRepository _comment;
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

        public IPullRecipeRepository PullRecipe
        {
            get
            {
                if (_pull == null) _pull = new PullRecipeRepository(_context);
                return _pull;
            }
        }
        public ILibraryRepository Library
        {
            get
            {
                if (_library == null) _library = new LibraryRepository(_context);
                return _library;
            }
        }

        public IReviewRepository Review

        {
            get
            {
                if (_review == null) _review = new ReviewRepository(_context);
                return _review;
            }
        }
        public ICommentRepository Comment

        {
            get
            {
                if (_comment == null) _comment = new CommentRepository(_context);
                return _comment;
            }
        }

        public IQuestionRepository Question
        {
            get
            {
                if (_question == null) _question = new QuestionRepository(_context);
                return _question;
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
