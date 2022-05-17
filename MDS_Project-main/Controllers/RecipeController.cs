﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.RecipeRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _repository;
        public RecipeController(IRecipeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRecipes()
        {
            var recipes = await _repository.GetAllRecipes();

            var recipesToReturn = new List<RecipeDTO>();

            foreach (var recipe in recipes)
            {
                recipesToReturn.Add(new RecipeDTO(recipe));
            }

            return Ok(recipesToReturn);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetRecipeById(int id)
        {
            var recipe = await _repository.GetRecipeById(id);

            RecipeDTO recipeToReturn = new RecipeDTO(recipe);

            return Ok(recipeToReturn);
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> GetAllRecipesByName(string name)
        {
            var recipes = await _repository.GetAllRecipesByName(name);

            var recipesToReturn = new List<RecipeDTO>();

            foreach (var recipe in recipes)
            {
                recipesToReturn.Add(new RecipeDTO(recipe));
            }

            return Ok(recipesToReturn);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeType(int id)
        {
            var Recipe = await _repository.GetByIdAsync(id);

            if (Recipe == null)
            {
                return NotFound("Recipe does not exist!");
            }

            _repository.Delete(Recipe);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRecipe(CreateRecipeDTO dto)
        {
            Recipe newRecipe = new Recipe();

            newRecipe.Name = dto.Name;

            _repository.Create(newRecipe);

            await _repository.SaveAsync();


            return Ok(new RecipeDTO(newRecipe));
        }
    }
}
