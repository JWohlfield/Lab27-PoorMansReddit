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

        //Why did we not need the next line this time?
        //private RedditDAL rd = new RedditDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Rootobject rp = new Rootobject();
            //Why don't I see indexes of children ???
            //Using JSON Viewer chrome extension...is JSONView better??
            Data1 basePath = rp.data.children[0].data;
            string title = basePath.title;
            string imageUrl = basePath.thumbnail;
            string link = "reddit.com" + basePath.permalink;

            return View(rp);
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
