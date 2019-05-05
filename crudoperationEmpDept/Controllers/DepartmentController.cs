using crudoperationEmpDept.Models;
using crudoperationEmpDept.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudoperationEmpDept.Controllers
{
    [Authorize(Roles ="Admin,Manager")]
    public class DepartmentController : Controller
    {
       ApplicationDbContext context = new ApplicationDbContext();
        // GET: Department
        public ActionResult Index()
        {
            return View(context.Departments.ToList());
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit");
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                context.Departments.Add(department);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddEdit");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var dept = context.Departments.FirstOrDefault(e => e.Id == id);
            if (dept != null)
            {
                ViewBag.Action = "Edit";
                return View("AddEdit", dept);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Department dept)
        {
            if (ModelState.IsValid)
            {
                var olddept = context.Departments.FirstOrDefault(e => e.Id == dept.Id);
                if (olddept != null)
                {
                    olddept.Name = dept.Name;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View("AddEdit", dept);
        }
        [Authorize(Roles = "Admin")]
        public bool Delete(int id)
        {
            Department dept = context.Departments.FirstOrDefault(e => e.Id == id);
            if (dept != null)
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public ActionResult Details(int id)
        {
            var department = context.Departments.Include("Employees").FirstOrDefault(e=>e.Id==id);
            if(department != null)
            {
                return View(department);
            }
            return RedirectToAction("Index");
        }
    }
}