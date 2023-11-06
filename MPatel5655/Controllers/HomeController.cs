using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MPatel5655.Models;
using System.Diagnostics;

namespace MPatel5655.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}