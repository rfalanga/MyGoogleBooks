using BookFinder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookFinder.Controllers
{
    public class TitleController : Controller
    {
        private readonly ILogger<TitleController> _logger;

        public TitleController(ILogger<TitleController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
