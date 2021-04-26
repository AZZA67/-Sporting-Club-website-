using Sportingclub1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Sportingclub1.Controllers
{
    public class SportsController : Controller
    {
        
        public ActionResult Index()
        {
            context c = new context();
           var spor = c.sports.ToList();
            return View(spor);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

 
        public ActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
             

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
    }
}
