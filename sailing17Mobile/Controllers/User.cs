using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sailing17Mobile.Models;
using log4net;

namespace sailing17Mobile.Controllers
{
    [UserAuthorize]
    public class UserController : Controller
    {
        //首页
        public ActionResult Index()
        {
            return View();
        }


        //我的订舱
        public ActionResult Orders(int? id){
            if (id == null) id = 1;
            AtlData2Model<UserOrder> a2m = new AtlData2Model<UserOrder>();
            List<UserOrder> orderlist = new List<UserOrder>();
            ATLDATALib.IDBDataAtl rs = SM.UserRPC.ShipBoxPriceControl.GetSailBoxList(
                "emp_id", Session["user_id"],
                "type", "2",
                "pagnum", id,
                "pagcount", 10
            );
            string pageCount = "0";
            if (rs.IsOK()) {
                orderlist = a2m.ConvertList(rs);
                pageCount = orderlist.FirstOrDefault().totalpag;
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
            ViewBag.pageCount = pageCount;
            ViewBag.page = id;
            return View(orderlist);
        }

        //订舱详细信息
        public ActionResult OrderDetail (string id) {
            UserOrder order = new UserOrder();
            ATLDATALib.IDBDataAtl rs = SM.UserRPC.ShipBoxPriceControl.GetSailBoxList(
                "emp_id", Session["user_id"],
                "type", "2",
                "jobno" , id
            );
            if (rs.IsOK()) {
                order = AtlData2Model<UserOrder>.Convert(rs);
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
            return View(order);
        }



        //我的押金
        public ActionResult Moneys()
        {
            return View();
        }



    }
}
