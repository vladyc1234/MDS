using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public virtual ICollection<MadeWith> MadeWiths { get; set; }
    }
}
