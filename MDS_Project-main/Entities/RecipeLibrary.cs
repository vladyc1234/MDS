using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class RecipeLibrary
    {
        public int IdRecipe { get; set; }
        public int IdLibrary { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual Library Library { get; set; }
    }
}
