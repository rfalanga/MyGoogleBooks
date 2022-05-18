using BookApi;
using BookFinder.Models;
using BookFinder.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

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
            TitleViewModel viewModel = null;
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Title")] TitleViewModel titleViewModel)
        {
            var root = await BookApi.BookApi.GetBooksByTitle(HttpUtility.HtmlEncode(titleViewModel.Title));
            titleViewModel.Root = (root == null) ? new BookApi.Models.Root() : root;
            return View(titleViewModel);
        }

    }
}
