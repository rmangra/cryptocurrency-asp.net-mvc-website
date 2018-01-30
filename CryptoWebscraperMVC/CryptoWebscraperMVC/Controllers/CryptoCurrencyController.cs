using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CryptoWebscraperMVC.Controllers
{
    public class CryptoCurrencyController : Controller
    {
        // GET: CryptoCurrency
        public ActionResult Index()
        {
            return View();
        }
    }
}