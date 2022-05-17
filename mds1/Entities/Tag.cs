using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RecipeTag> RecipeTags { get; set; }
        public virtual ICollection<DerivedTag> DerivedTags { get; set; }
    }
}
