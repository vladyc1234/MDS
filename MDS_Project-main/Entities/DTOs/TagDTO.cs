using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class TagDTO
    {
        public string Name { get; set; }

        public TagDTO(Tag tag)
        {
            this.Name = tag.Name;
        }
    }
}
