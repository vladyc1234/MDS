using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Library
    {
        public int Id { get; set; }
        public int IdRecipe { get; set; }
        public int IdUser { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<RecipeLibrary> RecipeLibraries { get; set; }
    }
}
