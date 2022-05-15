using BookFinder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookFinder.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
