using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class RecipeLibraryDTO
    {


        public int IdRecipe { get; set; }
        public int IdLibrary { get; set; }

        public RecipeLibraryDTO(RecipeLibrary rl)
        {
            this.IdLibrary = rl.IdLibrary;
            this.IdRecipe = rl.IdRecipe;
        }

       
    }
}
