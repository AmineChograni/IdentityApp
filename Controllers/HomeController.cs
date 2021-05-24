using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Controllers
{
    public class HomeController : Controller
    {
        private ProductDbContext DbContext;
        public HomeController(ProductDbContext ctx) => DbContext = ctx;
        public IActionResult Index() => View(DbContext.Products);
    }
}
