using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookApi.Models;
using Newtonsoft.Json;

namespace BookApi
{
    public class BookApi
    {
        public static async Task<Root?> GetBooksByAuthor(string htmlEncodedAuthorName)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //this is an example of a generic search: https://www.googleapis.com/books/v1/volumes?q=christie
                    //I need to find an example that searches specifically by author.
                    //That can be found here: https://developers.google.com/books/docs/v1/using#query-params
                    //Simple example using Christie: https://www.googleapis.com/books/v1/volumes?q=inauthor:christie

                    string authorNamesEncoded = $"https://www.googleapis.com/books/v1/volumes?q=inauthor:{htmlEncodedAuthorName}";

                    HttpResponseMessage? response = await client.GetAsync(authorNamesEncoded);
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();

                    var rootObject = JsonConvert.DeserializeObject<Root>(responseBody);

                    return rootObject;
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
