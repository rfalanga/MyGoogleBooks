using BookApi;
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
            BookApi.BookApi bookApi = new BookApi.BookApi();
            return View(bookApi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind()]BookApi.BookApi bookApi)
        {
            return View(bookApi);
        }

    }
}
