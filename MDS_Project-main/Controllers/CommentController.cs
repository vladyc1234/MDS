using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.CommentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _repository;
        public CommentController(ICommentRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            var comments = await _repository.GetAllComments();

            var commentsToReturn = new List<CommentDTO>();

            foreach (var comment in comments)
            {
                commentsToReturn.Add(new CommentDTO(comment));
            }

            return Ok(commentsToReturn);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            var comment = await _repository.GetCommentById(id);

            CommentDTO commentToReturn = new CommentDTO(comment);

            return Ok(commentToReturn);
        }

            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentType(int id)
        {
            var Comment = await _repository.GetByIdAsync(id);

            if (Comment == null)
            {
                return NotFound("Comment does not exist!");
            }

            _repository.Delete(Comment);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentDTO dto)
        {
            Comment newComment = new Comment();


            _repository.Create(newComment);

            await _repository.SaveAsync();


            return Ok(new CommentDTO(newComment));
        }
    }
}

