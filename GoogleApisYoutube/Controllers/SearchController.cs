using GoogleApisYoutube.Common;
using GoogleApisYoutube.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace GoogleApisYoutube.Controllers
{
    public class SearchController : Controller
    {
        ApiHelp ApiHelp = new ApiHelp();
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SearchViewModel ViewModel)
        {
            ViewModel.SearchResult = ApiHelp.GetData(ViewModel.SearchText);
            return View(ViewModel);
        }
    }
}