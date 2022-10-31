using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1.Models;

namespace task1.View_Models.Home
{
    public class HomeVM
    {
        public Brends Brends { get; set; }
        public Blog Blog { get; set; }
        public List<CarModels> CarModels { get; set; }
    }
}
