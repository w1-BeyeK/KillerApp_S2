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
    public class CityController : ControllerBase, ICustomController<City>
    {
        private readonly UnitOfWork uow;

        public CityController(UnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var city = uow.CityRepository.GetWithFilter(c => c.Id == id).FirstOrDefault();
            uow.CityRepository.Delete(city);

            return Ok();
        }

        public IActionResult GetAll()
        {
            return Ok(uow.CityRepository.GetAll());
        }

        public IActionResult GetById(long id)
        {
            return Ok(uow.CityRepository.GetWithFilter(c => c.Id == id).FirstOrDefault());
        }

        public IActionResult Insert(City obj)
        {
            uow.CityRepository.Insert(obj);

            return Ok();
        }

        public IActionResult Update(City obj, long id)
        {
            uow.CityRepository.Update(obj);

            return Ok();
        }
    }
}
