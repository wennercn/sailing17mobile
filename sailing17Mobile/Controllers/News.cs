using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sailing17Mobile.Models;

namespace sailing17Mobile.Controllers{

    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult Index(){
            AtlData2Model<News> a2m = new AtlData2Model<News>();
            List<News> newslist = new List<News>();
            ATLDATALib.IDBDataAtl rs = SM.RPC.ShipBoxPriceControl.GetNewsList("ntype", "");
            if (rs.IsOK()){
                newslist = a2m.ConvertList(rs);
            }else{
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
            return View(newslist);
        }

        //
        // GET: /News/Detail/5
        public ActionResult Detail(int id){
            News news = new News();
            ATLDATALib.IDBDataAtl rs = SM.RPC.ShipBoxPriceControl.GetNewsOne("new_id", id);
            if (rs.IsOK()) {
                news = AtlData2Model<News>.Convert(rs);
            } else {
                ViewBag.ErrorInfo = rs.GetErrorinfo();
            }
            ViewBag.title = news.title;
            return View(news);
        }

    }
}
