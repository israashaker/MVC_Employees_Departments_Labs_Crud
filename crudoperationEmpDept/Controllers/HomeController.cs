using crudoperationEmpDept.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudoperationEmpDept.Controllers
{
    public class HomeController : Controller
    {
        //ApplicationDbContext context;
        //ApplicationRoleManager roleManager;
        //ApplicationUserManager userManager;
        //public ApplicationDbContext Context
        //{
        //    get
        //    {
        //        return context ?? HttpContext.GetOwinContext().Get<ApplicationDbContext>();
        //    }
        //}
        //public ApplicationRoleManager RoleManager
        //{
        //    get
        //    {
        //        return roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
        //    }
        //}
        //public ApplicationUserManager UserManager
        //{
        //    get
        //    {
        //        return userManager ?? HttpContext.GetOwinContext().Get<ApplicationUserManager>();
        //    }
        //}
        public ActionResult Index()
        {
            //IdentityRole admin = new IdentityRole("Admin");
            //IdentityRole employee = new IdentityRole("Employee");
            //IdentityRole manager = new IdentityRole("Manager");
            //RoleManager.Create(admin);
            //RoleManager.Create(employee);
            //RoleManager.Create(manager);
            //ApplicationUser adminUser = UserManager.Users.FirstOrDefault(u => u.Email.StartsWith("admin"));
            //ApplicationUser employeeUser = UserManager.Users.FirstOrDefault(u => u.Email.StartsWith("employee"));
            //ApplicationUser managerUser = UserManager.Users.FirstOrDefault(u => u.Email.StartsWith("manager"));
            //userManager.AddToRole(adminUser.Id, admin.Name);
            //userManager.AddToRole(employeeUser.Id, employee.Name);
            //userManager.AddToRole(managerUser.Id, manager.Name);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}