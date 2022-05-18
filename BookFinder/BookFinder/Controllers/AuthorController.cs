using BookApi;
using BookFinder.Models;
using BookFinder.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

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
            //BookApi.BookApi bookApi = new BookApi.BookApi();
            //return View(bookApi);
            AuthorViewModel authorViewModel = null; // new AuthorViewModel();
            return View(authorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("AuthorName")] AuthorViewModel authorViewModel)
        {
            var root = await BookApi.BookApi.GetBooksByAuthor(HttpUtility.HtmlEncode(authorViewModel.AuthorName));
            authorViewModel.Root = (root == null) ? new BookApi.Models.Root() : root;
            return View(authorViewModel);
        }

    }
}
