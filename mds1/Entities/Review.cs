using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities
{
    public class Review
    {
        // rating -> like (+1) / dislike(-1)
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
        public int IdRecipe { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
