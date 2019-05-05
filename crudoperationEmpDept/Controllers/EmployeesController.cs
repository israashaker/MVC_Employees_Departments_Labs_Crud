using crudoperationEmpDept.Models;
using crudoperationEmpDept.Models.Entities;
using crudoperationEmpDept.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudoperationEmpDept.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        static ApplicationDbContext context= new ApplicationDbContext();
        public ActionResult Index()
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM.Employees = context.Employees.Include("Department").ToList();
            employeeVM.Departments = context.Departments.ToList();
            return View(employeeVM);
        }
        [HttpGet]
        [Authorize(Roles ="Admin,Manager")]
        public ActionResult Add()
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM.Departments = context.Departments.ToList(); 
            ViewBag.Action = "Add";
            return View("AddEdit",employeeVM);
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                //return RedirectToAction("Index");
                return PartialView("_PartialEmployee",employee);
            }
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM.Departments = context.Departments.ToList();
            ViewBag.Action = "Add";
            return View("AddEdit",employeeVM);
        }
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult Edit(int id)
        {
            var employee = context.Employees.FirstOrDefault(e => e.Id==id);
            if (employee != null)
            {
                EmployeeViewModel employeeVM = new EmployeeViewModel();
                employeeVM.Employee = employee;
                employeeVM.Departments = context.Departments.ToList();
                ViewBag.Action = "Edit";
                return View("AddEdit", employeeVM);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var oldEmp = context.Employees.FirstOrDefault(e => e.Id == employee.Id);
                if (oldEmp !=null)
                {
                    oldEmp.Name = employee.Name;
                    oldEmp.Email = employee.Email;
                    oldEmp.Age = employee.Age;
                    oldEmp.FK_DepartmentId = employee.FK_DepartmentId;
                    oldEmp.Gender = employee.Gender;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
           
            return View("AddEdit", employee);
        }
        [Authorize(Roles = "Admin,Manager")]
        public bool Delete(int id)
        {
            Employee employee = context.Employees.FirstOrDefault(e=>e.Id == id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}