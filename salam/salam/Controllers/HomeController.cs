using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using salam.Models;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace salam.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Student student1 = new Student()
            {
                Name = "Elcan",
                Surname = "Guluyev",
                Age = 15,
                Class = "P412"
            };

            Student student2 = new Student()
            {
                Name = "Nijat",
                Surname = "Mukhtarov",
                Age = 16,
                Class = "P112"
            };

            Student student3 = new Student()
            {
                Name = "Nuriya",
                Surname = "Gadmaliyeva",
                Age = 16,
                Class = "P221"
            };

            Student student4 = new Student()
            {
                Name = "Ali",
                Surname = "Mursaliyev",
                Age = 17,
                Class = "P312"
            };

            List<Student> students = new List<Student> { student1, student2, student3, student4 };

            return View(students);
            
        }
    }
}

