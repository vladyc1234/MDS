using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.UtensilRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtensilController : ControllerBase
    {
        private readonly IUtensilRepository _repository;
        public UtensilController(IUtensilRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUtensils()
        {
            var utensils = await _repository.GetAllUtensilsAsync();

            var utensilsToReturn = new List<UtensilDTO>();

            foreach (var utensil in utensils)
            {
                utensilsToReturn.Add(new UtensilDTO(utensil));
            }

            return Ok(utensilsToReturn);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUtensilType(int id)
        {
            var Utensil = await _repository.GetByIdAsync(id);

            if (Utensil == null)
            {
                return NotFound("Utensil does not exist!");
            }

            _repository.Delete(Utensil);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateUtensil(CreateUtensilDTO dto)
        {
            Utensil newUtensil = new Utensil();

            newUtensil.Name = dto.Name;

            _repository.Create(newUtensil);

            await _repository.SaveAsync();


            return Ok(new UtensilDTO(newUtensil));
        }
    }
}

