using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class TagDTO
    {
        public string Name { get; set; }
        public List<RecipeTag> RecipeTags { get; set; }
        public List<DerivedTag> DerivedTags { get; set; }

        public TagDTO(Tag tag)
        {
            this.Name = tag.Name;
            this.RecipeTags = new List<RecipeTag>();
            this.DerivedTags = new List<DerivedTag>();
        }
    }
}
