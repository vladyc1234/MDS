using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class RecipeTag
    {
        public int IdTag { get; set; }
        public int IdRecipe { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
