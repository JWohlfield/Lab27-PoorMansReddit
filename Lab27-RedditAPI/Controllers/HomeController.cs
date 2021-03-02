using Lab27_RedditAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27_RedditAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private RedditDAL rd = new RedditDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Child> posts = rd.GetPosts("aww");
            

            return View(posts);
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Result(string subreddit)
        {
            List<Child> posts = rd.GetPosts(subreddit);
            if(posts.Count == 0) 
            {
                TempData["error"] = "No posts were returned from the subreddit: " + subreddit;
            }
            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
