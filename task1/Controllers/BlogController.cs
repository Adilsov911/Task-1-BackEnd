using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1.Models;

namespace task1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            Blog blog = new Blog
            {
                Name = "Layout",
                Title = "Adoo",
                Content = "tapsirig"
            };

            return View(blog);
        }
    }
}
