using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.IngredientsRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepository _repository;
        public IngredientController(IIngredientRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllIngredients()
        {
            var ingredients = await _repository.GetAllIngredientsAsync();

            var ingredientsToReturn = new List<IngredientDTO>();

            foreach (var ingredient in ingredients)
            {
                ingredientsToReturn.Add(new IngredientDTO(ingredient));
            }

            return Ok(ingredientsToReturn);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredientType(int id)
        {
            var Ingredient = await _repository.GetByIdAsync(id);

            if (Ingredient == null)
            {
                return NotFound("Ingredient does not exist!");
            }

            _repository.Delete(Ingredient);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateIngredient(CreateIngredientDTO dto)
        {
            Ingredient newIngredient = new Ingredient();

            newIngredient.Name = dto.Name;

            _repository.Create(newIngredient);

            await _repository.SaveAsync();


            return Ok(new IngredientDTO(newIngredient));
        }
    }
}
