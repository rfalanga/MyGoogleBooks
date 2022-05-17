using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookApi.Models;

namespace BookFinder.Models.ViewModels
{
    public class AuthorViewModel
    {
        //public class BookFinder.Models.SimpleQuery SimpleQuery; //I still get a CS8618 warning here
        public SimpleQuery SimpleQuery { get; set; }    // and CS8618 error here, too, but it is at least simplier
    }
}
