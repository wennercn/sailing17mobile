using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sailing17Mobile.Models;

namespace sailing17Mobile.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost] 
        //FormCollection f  -> f["username"];
        //Request["username"]
        public ActionResult Check() {
            string name = Request["username"];
            string pass = Request["userpass"];

            if (name == "" || pass == "") {
                ViewBag.errors = "请输入用户名和密码!";
                return View("index");
            }

            ViewBag.username = name;
            ViewBag.userpass = pass;


            //检测
            string rs = checkLogin(name, pass);
            if (rs == "succ"){
                //转到登录前页面
                //TODO: 应该带上参数ROUTERDATA
                //string controller = Session["lastController"] != null ? Session["lastController"].ToString() : "";
                //string action = Session["lastAction"] != null ? Session["lastAction"].ToString() : "";
                //Session["lastController"] = null;
                //Session["lastAction"] = null;
                System.Web.Routing.RouteValueDictionary rv = new System.Web.Routing.RouteValueDictionary();
                if (Session["lastRouteValues"] != null) {
                    rv = (System.Web.Routing.RouteValueDictionary)Session["lastRouteValues"];
                }
                return RedirectToAction( rv["action"].ToString() , rv);
            }else{
                ViewBag.errors = rs;
                return View("index");
            }
        }


        private string checkLogin(string name, string pass) {

            try {
                _RPC MyLoader = new _RPC();
                ATLDATALib.IDBDataAtl MyLogin = MyLoader.EmployeeControl.Employee.Login(
                    "emp_code", name,
                    "password", pass
                );
                if (MyLogin.IsOK()) {
                    Session["session"] = MyLogin.GetStringTName("Session");
                    MyLoader.SetSession(Session["session"]);
                    SM.UserRPC = MyLoader;
                    Session["user_id"] = MyLogin.GetStringTName("emp_id");
                    Session["user_code"] = name;
                    Session["user_name"] = MyLogin.GetStringTName("fullname");
                    return "succ";
                } else {
                    return MyLogin.GetErrorinfo();
                }
            } catch (Exception e) {
                return "异常:"+e.Message;
            }

        }
    }
}
