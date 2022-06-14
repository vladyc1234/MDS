using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories;
using RecipesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IRepositoryWrapper _repository;
        private readonly IUserService _service;

        public UserController(IRepositoryWrapper repository, IUserService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _repository.User.GetAllUsers();

            return Ok(new { users });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var User = await _repository.User.GetByIdAsync(id);

            return Ok(new { User } );
        }


    }
}
