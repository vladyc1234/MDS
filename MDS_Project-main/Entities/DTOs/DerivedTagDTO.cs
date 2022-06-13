using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class DerivedTagDTO
    {
        public string NameTag { get; set; }
        public int IdDerivedRecipe { get; set; }

        public DerivedTagDTO(DerivedTag dt)
        {
            this.NameTag = dt.NameTag;
            this.IdDerivedRecipe = dt.IdDerivedRecipe;
        }
    }
}
