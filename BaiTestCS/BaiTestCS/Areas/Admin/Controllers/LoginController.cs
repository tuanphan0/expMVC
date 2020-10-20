using BaiTestCS.Areas.Admin.Commom;
using BaiTestCS.Areas.Admin.Data;
using BaiTestCS.Models.SQL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTestCS.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModels model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UesrDao();
                var result = dao.Login(model.UserName, model.PassWord);
                if (result)
                {
                    var user = dao.GetId(model.UserName);
                    var usersession = new UserLogin();
                    usersession.UserName = user.TenDangNhap;
                    usersession.UserID = user.MaKhachHang;
                    Session.Add(CommonConstant.User_Session,usersession);
                    return RedirectToAction("Login", "HomeController");
                }
                else
                {
                    ModelState.AddModelError("", "Dang NHap Khong Dung");
                }
            }
            return View("Login");
        }
    }
}