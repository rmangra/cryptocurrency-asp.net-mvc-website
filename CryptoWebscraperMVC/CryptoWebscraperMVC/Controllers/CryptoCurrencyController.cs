using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CryptoWebscraperMVC.Models;

namespace CryptoWebscraperMVC.Controllers
{
    public class CryptoCurrencyController : Controller
    {
        // GET: CryptoCurrency
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            using (DBModel1 db = new DBModel1())
            {
                var cryptocurrenyList = db.CryptoCurrencies.ToList<CryptoCurrency>();
                return Json(new { data = cryptocurrenyList }, JsonRequestBehavior.AllowGet);

            }
        }

    }
}