using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentsController : Controller
    {
        private List<Student> _students = new List<Student>
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


        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
