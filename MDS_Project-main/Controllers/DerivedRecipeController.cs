using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.DerivedRecipeRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DerivedRecipeController : ControllerBase
    {
        private readonly IDerivedRecipeRepository _repository;
        public DerivedRecipeController(IDerivedRecipeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDerivedRecipes()
        {
            var derivedRecipe = await _repository.GetAllDerivedRecipes();

            var derivedRecipeToReturn = new List<DerivedRecipeDTO>();

            foreach (var derRec in derivedRecipe)
            {
                derivedRecipeToReturn.Add(new DerivedRecipeDTO(derRec));
            }

            return Ok(derivedRecipeToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDerivedRecipeById(int id)
        {
            var derRec = await _repository.GetDerivedRecipeById(id);

            DerivedRecipeDTO derivedRecipeToReturn = new DerivedRecipeDTO(derRec);

            return Ok(derivedRecipeToReturn);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDerivedRecipeType(int id)
        {
            var derRec = await _repository.GetByIdAsync(id);

            if (derRec == null)
            {
                return NotFound("Derived recipe does not exist!");
            }

            _repository.Delete(derRec);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateDerivedRecipe(CreateDerivedRecipeDTO dto)
        {
            DerivedRecipe newDer = new DerivedRecipe();


            _repository.Create(newDer);

            await _repository.SaveAsync();


            return Ok(new DerivedRecipeDTO(newDer));
        }

        [HttpPut("UpdateForForm")]
        public async Task<IActionResult> UpdateAsync([FromBody] DerivedRecipe der)
        {
            var array_der = await _repository.GetAllDerivedRecipes();

            var derIndex = array_der.FindIndex((DerivedRecipe _der) => _der.Id.Equals(der.Id));

            array_der[derIndex] = der;

            return Ok(array_der);
        }
    }
}
