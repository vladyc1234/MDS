using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.CreateDTO
{
    public class CreateReviewDTO
    {

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
    }
}
