using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookApi.Models;

namespace BookApi
{
    public class BookApi
    {
        public async Root? GetBooksByAuthor(string authorNames)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //this is an example of a generic search: https://www.googleapis.com/books/v1/volumes?q=christie
                    //I need to find an example that searches specifically by author
                }
                catch (Exception)
                {
                    //an error has occurred, return an empty Root object
                    var emptyRoot = new Root();
                    return emptyRoot;
                }
            }
        }
    }
}
