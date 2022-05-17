using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
        public int IdRecipe { get; set; }
        public Recipe Recipe { get; set; }
    
        public CommentDTO(Comment comment)
        {
            this.Id = comment.Id;
            this.CreationDate = comment.CreationDate;
            this.Text = comment.Text;
            this.IdRecipe = comment.IdRecipe;
            this.Recipe = comment.Recipe;
        }
    }
}
