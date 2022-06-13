using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.RecipeLibraryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeLibraryController : ControllerBase
    {
        private readonly IRecipeLibraryRepository _repository;
        public RecipeLibraryController(IRecipeLibraryRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRecipeLibraries()
        {
            var RecipeLibraries = await _repository.GetAllRecipeLibrary();

            var RecipeLibrariesToReturn = new List<RecipeLibraryDTO>();

            foreach (var q in RecipeLibraries)
            {
                RecipeLibrariesToReturn.Add(new RecipeLibraryDTO(q));
            }

            return Ok(RecipeLibrariesToReturn);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeLibraryType(int id)
        {
            var RecipeLibrary = await _repository.GetByIdAsync(id);

            if (RecipeLibrary == null)
            {
                return NotFound("RecipeLibrary does not exist!");
            }

            _repository.Delete(RecipeLibrary);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRecipeLibrary(CreateRecipeLibraryDTO dto)
        {
            RecipeLibrary newRecipeLibrary = new RecipeLibrary();


            _repository.Create(newRecipeLibrary);

            await _repository.SaveAsync();


            return Ok(new RecipeLibraryDTO(newRecipeLibrary));
        }
    }
}
