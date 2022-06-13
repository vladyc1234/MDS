using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.MadeWithRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MadeWithController : ControllerBase
    {
        private readonly IMadeWithRepository _repository;
        public MadeWithController(IMadeWithRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMadeWiths()
        {
            var MadeWiths = await _repository.GetAllMadeWith();

            var MadeWithsToReturn = new List<MadeWithDTO>();

            foreach (var q in MadeWiths)
            {
                MadeWithsToReturn.Add(new MadeWithDTO(q));
            }

            return Ok(MadeWithsToReturn);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMadeWithType(int id)
        {
            var MadeWith = await _repository.GetByIdAsync(id);

            if (MadeWith == null)
            {
                return NotFound("MadeWith does not exist!");
            }

            _repository.Delete(MadeWith);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateMadeWith(CreateMadeWithDTO dto)
        {
            MadeWith newMadeWith = new MadeWith();


            _repository.Create(newMadeWith);

            await _repository.SaveAsync();


            return Ok(new MadeWithDTO(newMadeWith));
        }
    }
}

