using KillerApp.Api.Interface;
using KillerApp.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase, ICustomController<User>
    {
        private readonly UnitOfWork uow;

        public UserController(UnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var user = uow.UserRepository.GetWithFilter(u => u.Id == id).FirstOrDefault();
            uow.UserRepository.Delete(user);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(uow.UserRepository.GetAll());
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(new User()
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "k.beye@student.fontys.nl",
                Password = "Test123",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            return Ok(uow.UserRepository.GetWithFilter(u => u.Id == id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Insert(User obj)
        {
            uow.UserRepository.Insert(obj);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(User obj, long id)
        {
            uow.UserRepository.Update(obj);

            return Ok();
        }
    }
}
