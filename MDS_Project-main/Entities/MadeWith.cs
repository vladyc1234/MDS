using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class MadeWith
    {
        public int IdIngredient { get; set; }
        public int IdRecipe { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
