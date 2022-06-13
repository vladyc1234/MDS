using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.CookedWithRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookedWithController : ControllerBase
    {
        private readonly ICookedWithRepository _repository;
        public CookedWithController(ICookedWithRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCookedWiths()
        {
            var CookedWiths = await _repository.GetAllCookedWith();

            var CookedWithsToReturn = new List<CookedWithDTO>();

            foreach (var q in CookedWiths)
            {
                CookedWithsToReturn.Add(new CookedWithDTO(q));
            }

            return Ok(CookedWithsToReturn);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCookedWithType(int id)
        {
            var CookedWith = await _repository.GetByIdAsync(id);

            if (CookedWith == null)
            {
                return NotFound("CookedWith does not exist!");
            }

            _repository.Delete(CookedWith);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateCookedWith(CreateCookedWithDTO dto)
        {
            CookedWith newCookedWith = new CookedWith();

            _repository.Create(newCookedWith);

            await _repository.SaveAsync();


            return Ok(new CookedWithDTO(newCookedWith));
        }
    }
}

