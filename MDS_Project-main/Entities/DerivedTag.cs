using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class DerivedTag
    {
        public string  NameTag { get; set; }
        public int IdDerivedRecipe { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual DerivedRecipe DerivedRecipe { get; set; }
    }
}
