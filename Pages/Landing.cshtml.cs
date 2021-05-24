using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Pages
{
    public class LandingModel : PageModel
    {
        public LandingModel(ProductDbContext ctx) => DbContext = ctx;
        public ProductDbContext DbContext { get; set; }
    }
}
