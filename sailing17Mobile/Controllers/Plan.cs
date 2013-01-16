using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sailing17Mobile.Models;
using log4net;

namespace sailing17Mobile.Controllers
{


    public class PlanController : Controller
    {


        public ActionResult Index(){
            AtlData2Model<Plan> s = new AtlData2Model<Plan>();
            List<Plan> planlist = new List<Plan>();

            object o = System.Configuration.ConfigurationManager.GetSection("log4net");
            log4net.Config.XmlConfigurator.Configure(o as System.Xml.XmlElement);
            log4net.ILog logger = log4net.LogManager.GetLogger("WebLogger");

            logger.Info("读取计划");

            string condition = "replace(ep.etd1,'后告','00:00:00')>='1900-01-01 00:00:00' and replace(ep.etd1,'后告','00:00:00')<='"+DateTime.Now.ToString()+" 23:59:59' and  loc.loc_name not in ( '改航', '离港') ";
            ATLDATALib.IDBDataAtl rs = SM.RPC.ProcessControl.GetShipList1("condition", condition, "type", "five");

            logger.Info("转换 atldata2model");

            if (rs.IsOK()){
                planlist = s.ConvertList(rs);
            }else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }

            //planlist = planlist.Take(10).ToList();
            logger.Info("返回");
            return View(planlist);
        }


    }
}
