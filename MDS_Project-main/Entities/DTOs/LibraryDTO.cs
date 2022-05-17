using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class LibraryDTO
    {
        public int Id { get; set; }
        public int IdRecipe { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public List<RecipeLibrary> RecipeLibraries { get; set; }

        public LibraryDTO(Library library)
        {
            this.Id = library.Id;
            this.IdRecipe = library.IdRecipe;
            this.IdUser = library.IdUser;
            this.User = library.User;
            this.RecipeLibraries = new List<RecipeLibrary>();
        }
    }
}
