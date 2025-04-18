﻿using OnlineShop.Areas.Admin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var session = (UserLogin) Session[CommonConstant.ADMIN_SESSION];
            if(session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { controller = "LogIn", action = "Index", Area = "Admin" }));
            }

            base.OnActionExecuting(filterContext);
        }
        protected void SetAlert(string message, string type)
        {
            //đối tượng tempdata có thể path dc từ server về
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
    }
}