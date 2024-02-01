
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feb1praticecustomer.Models;


namespace Feb1praticecustomer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        static List<Emp> listEmp = new List<Emp>
        {
          new Emp{Id=1,Name="venu",Salary=10000,Designation="HR" },
          new Emp{Id=2,Name="Raj",Salary=90000,Designation="Developer" },
          new Emp{Id=3,Name="John",Salary=80000,Designation="Manager" },
          new Emp{Id=4,Name="vadde",Salary=70000,Designation="Tester" },
        };
        public ActionResult Index()
        {
            ViewBag.msg = "Welcome to Customer";
            ViewBag.noEmp = listEmp.Count;
           ViewBag.txt = "Success";
            return View(listEmp);
        }
        public ActionResult Create()
        {
           ViewBag.txt = "Success";
            return View(new Emp());
        }
        [HttpPost]
        public ActionResult Create(Emp emp)
        {
            if (ModelState.IsValid)
            {
                listEmp.Add(emp);
                TempData["tempmsg"] = "New Employee Registration Success";
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }


        }
    }
}
