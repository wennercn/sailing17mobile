using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sailing17Mobile.Models;

namespace sailing17Mobile.Controllers
{

    public class HomeController : Controller
    {   
        //[UserAuthorize]
        public ActionResult Index(){

            ATLDATALib.IDBDataAtl rs = SM.RPC.ShipBoxPriceControl.GetNewsList("ntype", "");
            ViewBag.news = rs;
            return View();
        }
    }
}
