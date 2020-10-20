using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTestCS.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var khoaRp = new KhoaRepository();
            filterContext.Controller.ViewBag.Khoas = khoaRp.GetAllKhoa();
        }
    }
   
}