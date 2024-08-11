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
    public class SecondTaskController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SecondTaskController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View();
        }
    }
}

