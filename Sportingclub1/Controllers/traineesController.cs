using Sportingclub1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Sportingclub1.Controllers
{
    public class traineesController : Controller
    {
        SqlConnection con = new SqlConnection();
        context c = new context();
        public ActionResult Index()
        {
            var trainees =c.trainees.ToList();
            return View();
        }
        public ActionResult Details(Account account)
        {
            using (context c = new context())
            {
                return View(c.trainees.Where(x => x.Email == account.Email).FirstOrDefault());
            }
        }
        //public ActionResult Details(int id)
        //{
        //    using (context c = new context())
        //    {
        //        return View(c.trainees.Where(x => x.ID == id).FirstOrDefault());
        //    }
        //}
        // GET: trainees/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new trainees());
        }

        // POST: trainees/Create
        [HttpPost]
        public ActionResult Create(trainees tr)
        {
            con.ConnectionString = "Data Source=DESKTOP-CKHD3I1\\SQLEXPRESS ;  Initial Catalog= SportingClub; Integrated Security=true";
            if (ModelState.IsValid)
            {
                c.trainees.Add(tr);
                c.SaveChanges();
                SqlCommand cmd = new SqlCommand("INSERT INTO Accounts (Email, Password) SELECT Email , Password FROM trainees", con);
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToAction("Login", "Account");
            }
            else
                return View(tr);
        }  
        public ActionResult Edit(int id)
        {
            using (context c = new context())
            {
                return View(c.trainees.Where(x => x.ID == id).FirstOrDefault());
            }
        }
        // POST: trainees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, trainees trainee)
        {
            try
            {
                using (context c = new context())
                {
                    c.Entry(trainee).State = EntityState.Modified;
                    c.SaveChanges();
                }
                return RedirectToAction("Login","Account");
            }
            catch
            {
                return View();
            }
        }
        // GET: trainees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: trainees/Delete/5
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

        
    

