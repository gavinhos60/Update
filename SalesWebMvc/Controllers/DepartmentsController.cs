using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
          
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { id = 1, Name = "Eletrônicos", Email = "eletronicos@hotmail.com" });
            list.Add(new Departament { id = 2, Name = "Fashion", Email = "fashion@gmail.com" });

            return View(list);
        }
    }
}