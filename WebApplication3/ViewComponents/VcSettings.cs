using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.ViewComponents
{
    public class VcSettings:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcSettings(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            Settings settings =   _context.Settings.FirstOrDefault();
            return View(settings);
        }
    }
}
