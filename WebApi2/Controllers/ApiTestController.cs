using CodingAssignment.Spotify.ApiClient;
using CodingAssignment.Spotify.ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;


namespace WebApi2.Controllers
{
    public class ApiTestController : Controller
    {
        // GET: ApiTest
        public async Task<ActionResult> ShowRecommend(string searchString,string searchGenre)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var client = new SpotifyApiClient();
                var response = await client.SearchArtistsAsync(searchString, searchGenre);
                var artists = response.Artists.Items;
                return View(artists);
            }
            else
            {
                return View("Search");
            }
           
        }


        public ActionResult Search()
        {
            return View();
        }
    }
}