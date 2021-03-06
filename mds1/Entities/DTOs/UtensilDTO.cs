using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Entities.DTOs
{
    public class UtensilDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CookedWith> CookedWiths { get; set; }

        public UtensilDTO(Utensil utensil)
        {
            this.Id = utensil.Id;
            this.Name = utensil.Name;
            this.Description = utensil.Description;
            this.CookedWiths = new List<CookedWith>();
        }
    }
}
