using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sailing17Mobile.Models;
using sailing17Mobile.Models.Customer;

namespace sailing17Mobile.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //简介
        public ActionResult About (string id) {
            AtlData2Model<Customer> a2m = new AtlData2Model<Customer>();
            Customer customer = new Customer();
            ATLDATALib.IDBDataAtl rs = SM.RPC.ShipBoxPriceControl.GetShipMemo(
                "ntype", id
            );
            if (rs.IsOK()) {
                customer = a2m.Convert(rs);
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
            return View(customer);
        }

        //新闻
        public ActionResult News () {
            return View();
        }

        //新闻详细
        public ActionResult NewsDetail () {
            return View();
        }

        //船期
        public ActionResult Plan () {
            return View();
        }
        
        //下载
        public ActionResult Download () {
            return View();
        }

        //滚动互动
        [UserAuthorize]
        public ActionResult Five () {
            return View();
        }

    }
}
