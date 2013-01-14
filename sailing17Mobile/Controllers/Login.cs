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

            //检测
            string rs = checkLogin(name, pass);
            if (rs == "succ"){
                //TODO: 应该返回进入的页面
                return RedirectToAction("" , "Home");
            }else{
                ViewBag.errors = rs;
                return View("index");
            }
        }


        private string checkLogin(string name, string pass) {

            try {
                _RPC MyLoader = new _RPC();
                ATLDATALib.IDBDataAtl MyLogin;
                MyLogin = MyLoader.EmployeeControl.Employee.Login(
                    "emp_code", name,
                    "password", pass
                );
                if (MyLogin.IsOK()) {
                    Session["session"] = MyLogin.GetStringTName("Session");
                    MyLoader.SetSession(Session["session"]);
                    SM.RPC = MyLoader;
                    Session["user_id"] = MyLogin.GetStringTName("emp_id");
                    Session["user_code"] = name;
                    Session["user_name"] = MyLogin.GetStringTName("fullname");
                    return "succ";
                } else {
                    return MyLogin.GetErrorinfo();
                }
            } catch (Exception e) {
                return e.Message;
            }

        }
    }
}
