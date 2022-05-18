namespace BookFinder.Models.ViewModels
{
    public class AuthorViewModel
    {
        //public class BookFinder.Models.SimpleQuery SimpleQuery; //I still get a CS8618 warning here
        //public SimpleQuery SimpleQuery { get; set; }    // and CS8618 error here, too, but it is at least simplier
        public string AuthorName { get; set; }

        public AuthorViewModel()
        {
            AuthorName = "";
        }
    }
}
