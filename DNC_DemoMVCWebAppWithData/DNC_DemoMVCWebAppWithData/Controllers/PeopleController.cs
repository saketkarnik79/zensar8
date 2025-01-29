using DNC_DemoMVCWebAppWithData.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNC_DemoMVCWebAppWithData.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Details()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Foo",
                DateOfBirth = DateTime.Parse("19-Jan-1970"),
                Email = "foo@bar.com"
            };
            //ViewData.Model = person;
            //return View();
            return View(person);
        }
    }
}
