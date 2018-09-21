using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using TicketSystemWeb.Data;

namespace TicketSystemWeb.Controllers
{
    public class _StudentController : Controller
    {
        private ApplicationDbContext _context;

        public _StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            
            return View(students);
        }
    }
}