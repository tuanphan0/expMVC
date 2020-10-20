using BaiTestCS.Models;
using BaiTestCS.XuLyDuLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace BaiTestCS.Controllers
{
    public class DSSVController : Controller
    {
        // GET: DSSV
        public ActionResult Index(string strSearch)
        {
            XuLyDuLieuSinhVien xl = new XuLyDuLieuSinhVien();
            List<StudentSQLModels> list = xl.getStudentSQL(string.Empty).OrderBy(x => x.FullName).ToList();
            if (!String.IsNullOrEmpty(strSearch))
            {
                //if (strSearch == "")
                //{
                //    list = xl.getStudentSQL(string.Empty).OrderBy(x => x.FullName).ToList();
                //}
                //else
                //{
                    list = list.Where(x => x.FullName.Contains(strSearch)).ToList();
            //    }
            }
            //else
            //{
            //    list = xl.getStudentSQL(string.Empty).OrderBy(x => x.FullName).ToList();
            //}
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentSQLModels stu)
        {
            if (ModelState.IsValid)
            {
                XuLyDuLieuSinhVien xl = new XuLyDuLieuSinhVien();
                xl.Addstudent(stu);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string id = "")
        {
            XuLyDuLieuSinhVien xl = new XuLyDuLieuSinhVien();
            List<StudentSQLModels> obj = xl.getStudentSQL(id);

            return View(obj.FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(StudentSQLModels stu)
        {
            XuLyDuLieuSinhVien xl = new XuLyDuLieuSinhVien();
            xl.EditStudents(stu);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id = "")
        {
            XuLyDuLieuSinhVien xl = new XuLyDuLieuSinhVien();
            List<StudentSQLModels> obj = xl.getStudentSQL(id);
            return View(obj.FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(StudentSQLModels stu)
        {
            XuLyDuLieuSinhVien xl = new XuLyDuLieuSinhVien();
            xl.DeleteStudents(stu);
            return RedirectToAction("Index");
        }
    }
}