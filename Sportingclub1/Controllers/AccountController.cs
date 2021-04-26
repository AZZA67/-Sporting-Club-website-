using Sportingclub1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Sportingclub1.Controllers
{
    public class AccountController : Controller
    {

        SqlConnection con = new SqlConnection();
        //SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "Data Source=DESKTOP-CKHD3I1\\SQLEXPRESS ;  Initial Catalog= SportingClub; Integrated Security=true";

        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            SqlCommand cmd = new SqlCommand("select * from Accounts where  Email=@Email and   Password=@Password", con);

            connectionString();
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = account.Email;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = account.Password;
            dr = cmd.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    con.Close();
                    return RedirectToAction("Details", "trainees", account);
                }
                else
                {
                    con.Close();
                    return View("error");
                }
            }
            catch (InvalidCastException ex)
            {
                return View("error");
            }
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session["Login"] = null;
            Session.Abandon();
            return View();

        }
    }
}
