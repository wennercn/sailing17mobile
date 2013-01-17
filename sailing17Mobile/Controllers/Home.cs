using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using sailing17Mobile.Models;
using sailing17Mobile.Models.Customer;

namespace sailing17Mobile.Controllers
{

    public class HomeController : Controller
    {   
        //[UserAuthorize]
        public ActionResult Index(){

            //新闻
            AtlData2Model<News> a2m = new AtlData2Model<News>();
            List<News> newslist = new List<News>();

            ATLDATALib.IDBDataAtl rs = SM.RPC.ShipBoxPriceControl.GetNewsList("ntype", "");
            if (rs.IsOK()) {
                newslist = a2m.ConvertList(rs);
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
            newslist = newslist.Take(10).ToList();
            ViewBag.newslist = newslist;

            //客户列表
            AtlData2Model<Customer> c_a2m = new AtlData2Model<Customer>();
            List<Customer> customerlist = new List<Customer>();
            ATLDATALib.IDBDataAtl c_rs = SM.RPC.ShipBoxPriceControl.GetShipMemo("ntype", "");
            if (rs.IsOK()) {
                customerlist = c_a2m.ConvertList(c_rs);
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
            ViewBag.customerlist = customerlist;

            return View();

        }
    }
}
