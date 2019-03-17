using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Api.Interface
{
    interface ICustomController<T> where T : class
    {
        IActionResult GetAll();
        IActionResult GetById(long id);
        IActionResult Insert(T obj);
        IActionResult Update(T obj, long id);
        IActionResult Delete(long id);
    }
}
