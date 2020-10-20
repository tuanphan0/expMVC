using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
namespace BaiTestCS.Controllers
{
    public class KhoaController : BaseController
    {
        private readonly KhoaRepository khoaRp;
        public KhoaController()
        {
            khoaRp = new KhoaRepository();
        }
        // GET: Student
        public ActionResult Index(int page = 1, int pagesize = 3)
        {
            var stu = khoaRp.GetAll(page, pagesize);
            return View(stu);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student stu)
        {
            try
            {
                khoaRp.Create(stu);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Khoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {

            var stu = khoaRp.GetById(id);
            return View(stu);
        }

        // POST: Khoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection formCollection)
        {
            try
            {
                var delete = khoaRp.Delete(id);
                if (delete)
                {
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult IndexKhoa()
        {
            var khoa = khoaRp.GetAllKhoa();
            return View(khoa);
        }
        //[HttpGet]
        //public ActionResult PageStudent()
        //{
        //    var stu = khoaRp.GetAllStu();
        //    return View(stu);
        //}

    }
}
