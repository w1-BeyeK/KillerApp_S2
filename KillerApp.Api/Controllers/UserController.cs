using KillerApp.Api.Interface;
using KillerApp.Api.Models;
using Microsoft.AspNetCore.Http;
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
            this.uow = UnitOfWork.GetInstance();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            try
            {
                var user = uow.UserRepository.GetWithFilter(u => u.Id == id).FirstOrDefault();

                if (user == null)
                    return BadRequest("User does not exist");

                uow.UserRepository.Delete(user);

                return NoContent();
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(uow.UserRepository.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
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
            try
            {
                return Ok(uow.UserRepository.GetWithFilter(u => u.Id == id).FirstOrDefault());
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Insert(KillerApp.Api.Models.User obj)
        {
            try
            {
                User user = uow.UserRepository.GetWithFilter(u => u.Name == obj.Name || u.Email == obj.Email).FirstOrDefault();
                if (user != null)
                    return BadRequest("User already exists");
                
                return Ok(uow.UserRepository.Insert(obj));
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
            
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("{id}")]
        public IActionResult Update(KillerApp.Api.Models.User obj, long id)
        {
            try
            {
                if (obj.Id != id)
                    return BadRequest("Ids do not match");

                User user = uow.UserRepository.GetWithFilter(u => u.Id == id).FirstOrDefault();
                if (user == null)
                    return BadRequest("User does not exist");
                
                return Ok(uow.UserRepository.Update(obj));
            }
            catch(Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
