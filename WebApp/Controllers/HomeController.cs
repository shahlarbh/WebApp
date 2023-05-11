using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id= 1,
                    Firstname = "Sahlar",
                    Lastname = "Haciyev",
                    Age = 25,
                },

                new Student
                {
                    Id= 2,
                    Firstname = "Ayxan",
                    Lastname = "Bayramov",
                    Age = 18,
                },

                new Student
                {
                    Id= 3,
                    Firstname = "Rauf",
                    Lastname = "Mehraliyev",
                    Age = 18,
                },
            };

            return View(students);
        }
    }
}
