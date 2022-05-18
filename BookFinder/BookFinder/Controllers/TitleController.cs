using BookApi;
using BookFinder.Models;
using BookFinder.Models.ViewModels;
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
            TitleController titleController = null;
            return View(titleController);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Title")] TitleViewModel titleViewModel)
        {
            return View(titleViewModel);
        }

    }
}
