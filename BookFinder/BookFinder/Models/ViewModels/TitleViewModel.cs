using BookApi.Models;

namespace BookFinder.Models.ViewModels
{
    public class TitleViewModel
    {
        public string Title{ get; set; }

        public Root Root { get; set; }

        public TitleViewModel()
        {
            Title = "";
            Root = new Root();
        }
    }
}
