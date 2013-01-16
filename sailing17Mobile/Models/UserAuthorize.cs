using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sailing17Mobile.Models {
    /// <summary>
    /// 自定义AuthorizeAttribute
    /// </summary>
    public class UserAuthorizeAttribute : AuthorizeAttribute {

        public override void OnAuthorization(AuthorizationContext filterContext) {

            if (filterContext.HttpContext.Session["user_id"] == null) {

                string controller = filterContext.RouteData.Values["controller"].ToString();
                string action = filterContext.RouteData.Values["action"].ToString();
                filterContext.HttpContext.Session["lastController"] = controller;
                filterContext.HttpContext.Session["lastAction"] = action;
                filterContext.HttpContext.Response.Redirect(new UrlHelper(filterContext.RequestContext).Action("", "Login"));
                filterContext.Result = new EmptyResult();
            }

            /*
            var user = filterContext.HttpContext.Session["CurrentUser"] as UM_USER;
            // 用户为空，赋予Guest
            if (user == null){
                user = db.UM_USER.Find(u => u.Name == "Guest");
            }

            var controller = filterContext.RouteData.Values["controller"].ToString();
            var action = filterContext.RouteData.Values["action"].ToString();
            var isAllowed = this.IsAllowed(user, controller, action);

            if (!isAllowed)
            {
                filterContext.RequestContext.HttpContext.Response.Write("无权访问");
                filterContext.RequestContext.HttpContext.Response.End();
            }
            */
        }

        /// <summary>
        /// 判断是否允许访问
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="controller">控制器</param>
        /// <param name="action">action</param>
        /// <returns>是否允许访问</returns>

        public bool IsAllowed(string controller, string action) {
            return true;
            /*
            // 找controllerAction
            var controllerAction = db.ControllerActions.Find(ca => ca.IsController == false && ca.Name == action && ca.ControllName == controller);

            //action无记录，找controller
            if (controllerAction == null)
            {
                controllerAction = db.ControllerActions.Find(ca => ca.IsController && ca.Name == controller);
            }

            // 无规则
            if (controllerAction == null)
            {
                return true;
            }


            // 允许没有角色的：也就是说允许所有人，包括没有登录的用户 
            if (controllerAction.IsAllowedNoneRoles)
            {
                return true;
            }

            // 允许所有角色：只要有角色，就可以访问 
            if (controllerAction.IsAllowedAllRoles)
            {
                var roles = db.UserRoles.FindAll(ur => ur.UserId == user.Id);
                if (roles.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            // 选出action对应的角色 
            var actionRoles = db.ControllerActionRoles.FindAll(ca => ca.ControllerActioId == controllerAction.Id).ToList();

            if (actionRoles.Count == 0)
            {
                // 角色数量为0，也就是说没有定义访问规则，默认允许访问 
                return true;
            }

            var userHavedRolesids = db.UserRoles.FindAll(ur => ur.UserId == user.Id).Select(ca => ca.RoleId).ToList();

            // 查找禁止的角色 
            var notAllowedRoles = actionRoles.FindAll(r => !r.IsAllowed).Select(ca => ca.RoleId).ToList();
            if (notAllowedRoles.Count > 0)
            {
                foreach (int roleId in notAllowedRoles)
                {
                    // 用户的角色在禁止访问列表中，不允许访问 
                    if (userHavedRolesids.Contains(roleId))
                    {
                        return false;
                    }
                }
            }

            // 查找允许访问的角色列表 
            var allowRoles = actionRoles.FindAll(r => r.IsAllowed).Select(ca => ca.RoleId).ToList();
            if (allowRoles.Count > 0)
            {
                foreach (int roleId in allowRoles)
                {
                    // 用户的角色在访问的角色列表 
                    if (userHavedRolesids.Contains(roleId))
                    {
                        return true;
                    }
                }
            }

            // 默认禁止访问
            return false;
             */
        }

    }
}