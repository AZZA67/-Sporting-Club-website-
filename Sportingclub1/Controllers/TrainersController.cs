using Sportingclub1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sportingclub1.Controllers
{
    public class TrainersController : Controller
    {
        // GET: Trainers
        public ActionResult Index()
        {
            context c = new context();
            //    List<Sports> sports = new List<Sports>();
            var trainers = c.trainers.ToList();
            return View(trainers);
        }

        // GET: Trainers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trainers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trainers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trainers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trainers/Edit/5
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

        // GET: Trainers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trainers/Delete/5
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
