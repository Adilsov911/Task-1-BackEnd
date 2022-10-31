using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1.Models;
using task1.View_Models.Home;

namespace task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<CarModels> _carModels;
        public HomeController()
        {
            _carModels = new List<CarModels>
            {
                new CarModels{
                    Id = 1,
                    Name = "BMW",
                    Brends = new List<Brends>
                    {
                        new Brends
                        {
                            Name="525",
                            Count = 22500
                        },
                        new Brends
                        {
                            Name="760",
                            Count = 102500
                        },
                        new Brends
                        {
                            Name="740",
                            Count = 95000
                        },
                        new Brends
                        {
                            Name="323",
                            Count = 35000
                        },
                    }
                },
                new CarModels{Id = 2, Name = "Mercedes-Benz"},
                new CarModels{Id = 3, Name = "Toyota"}
            };
        }
        public IActionResult Index()
        {
            Brends brend = new Brends
            {
                Name = "Adil",
            };

            Blog blog = new Blog
            {
                Name = "Layout",
                Title = "Adoo",
                Content = "tapsirig"
            };
            HomeVM homeVM = new HomeVM
            {
                Brends = brend,
                Blog = blog,
                CarModels =_carModels
            };

            return View(homeVM);
        }
        public IActionResult Detail(int? id)
        {
            CarModels carModels = _carModels.Find(g => g.Id == id);


            return View(carModels);
        }
    }
}
