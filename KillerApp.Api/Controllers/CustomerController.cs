using KillerApp.Api.Interface;
using KillerApp.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace KillerApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase, ICustomController<Customer>
    {
        private readonly UnitOfWork uow;

        public CustomerController(UnitOfWork uow)
        {
            this.uow = uow;
        }

        public IActionResult Index()
        {
            Customer c = new Customer()
            {
                Address = "2e Vijverstraat 2",
                BirthDate = DateTime.Now,
                City = "Den Bosch",
                Country = "Netherlands",
                CountryCode = new char[2] { 'N', 'L' },
                DateCreated = DateTime.Now,
                Email = "k.beye@student.fontys.nl",
                FirstName = "Kevin",
                Id = 1,
                LastName = "Beye",
                Password = "Kevin123",
                MiddleName = "",
                Token = "",
                ZipCode = "5258HS"
            };

            return Ok(c);
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Insert(Customer obj)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Customer obj, long id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            return Ok();
        }
    }
}
