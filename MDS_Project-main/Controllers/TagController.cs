using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.TagRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagRepository _repository;
        public TagController(ITagRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {
            var tags = await _repository.GetAllTags();

            var tagsToReturn = new List<TagDTO>();

            foreach (var tag in tags)
            {
                tagsToReturn.Add(new TagDTO(tag));
            }

            return Ok(tagsToReturn);
        }

        [HttpGet("{name:string}")]
        public async Task<IActionResult> GetTagByName(string name)
        {
            var tag = await _repository.GetByNameAsync(name);

            TagDTO tagToReturn = new TagDTO(tag);

            return Ok(tagToReturn);
        }

        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteTagType(string name)
        {
            var Tag = await _repository.GetByNameAsync(name);

            if (Tag == null)
            {
                return NotFound("Tag does not exist!");
            }

            _repository.Delete(Tag);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagDTO dto)
        {
            Tag newTag = new Tag();

            newTag.Name = dto.Name;

            _repository.Create(newTag);

            await _repository.SaveAsync();


            return Ok(new TagDTO(newTag));
        }
    }
}
