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
        public string Gcustomer_code = "";
        public Customer Gcustomer = new Customer();

        public void GetCustome(){
            Gcustomer_code= ControllerContext.RouteData.Values["code"].ToString();
            ATLDATALib.IDBDataAtl rs = SM.RPC.ShipBoxPriceControl.GetShipMemo(
                "ntype", Gcustomer_code
            );
            if (rs.IsOK()) {
                Gcustomer = AtlData2Model<Customer>.Convert(rs);
                ViewData["customer"] = Gcustomer;
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
        }

        public ActionResult Index(){
            return View(Gcustomer);
        }

        //简介
        public ActionResult About (string code) {
            GetCustome();
            return View(Gcustomer);
        }

        //新闻
        public ActionResult News () {
            GetCustome();
            return View();
        }

        //新闻详细
        public ActionResult NewsDetail () {
            GetCustome();
            return View();
        }

        //船期
        public ActionResult Plan () {
            GetCustome();

            XiaMen.PublicQueryService ws = new XiaMen.PublicQueryService();


            string errorMessage;
            System.Data.DataTable dt = ws.ImportArrivalQuery(
                "111" , 
                "222" , 
                "2013-01-01" , 
                "2013-01-30" , 
                out errorMessage
            );

            ViewBag.dt = dt;
            ViewBag.wserr = errorMessage;

            return View();
        }
        
        //下载
        public ActionResult Download () {
            GetCustome();
            return View();
        }

        //滚动互动
        [UserAuthorize]
        public ActionResult Five (string id) {
            GetCustome();
            AtlData2Model<Plan> a2m = new AtlData2Model<Plan>();
            List<Plan> planlist = new List<Plan>();

            string etd_start = "1901-01-01";
            string etd_end = DateTime.Now.ToString();

            String condition = "replace(ep.etd1,'后告','00:00:00')>='" + etd_start + " 00:00:00' and replace(ep.etd1,'后告','00:00:00')<='" + etd_end + " 23:59:59' and  loc.loc_name not in ( '改航') and give_trust = '" + Gcustomer.customer_id + "'";

            ATLDATALib.IDBDataAtl rs = SM.UserRPC.ProcessControl.GetShipList1("condition", condition, "type", "five");
            
            if (rs.IsOK()) {
                planlist = a2m.ConvertList(rs);
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }

            //planlist = planlist.Take(10).ToList();

            return View(planlist);
        }

    }
}
