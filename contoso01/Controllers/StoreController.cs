using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace contoso01.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hi from the Store Controller --> index page";
        }
        public string Browse(string genre)
        {
            string message =
                HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }
        public string Details()
        {
            return "Hi from the Store Controller --> details page";
        }
    }
}