using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTestCS.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        QlSinhVienData data;

        public StudentController() {
            _studentRepository = new StudentRepository();
            data = new QlSinhVienData();
        }
        // GET: Student
        public ActionResult Index()
        {
            //sua code
            var stds = _studentRepository.GetStudents();
            return View(stds);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            ViewBag.khoa = new SelectList(data.Khoa.ToList().OrderBy(x => x.Ten), "Id", "Ten");
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ViewBag.khoa = new SelectList(data.Khoa.ToList().OrderBy(x => x.Ten), "Id", "Ten");
                _studentRepository.Create(student);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
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
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
