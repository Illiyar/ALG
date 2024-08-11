using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALG.Data;
using ALG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALG.Controllers
{
    public class FirstTaskController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FirstTaskController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var coutry = _db.Countries.Include("Cities").ToList();
            return View(coutry);
        }
        public IActionResult Details(int? Id)
        {
            if(Id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            Country? country = _db.Countries.Include("Cities").FirstOrDefault(c => c.Id == Id);

            if(country == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(country);
        }
    }
}

