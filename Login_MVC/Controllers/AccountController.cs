using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_MVC.Models;
using System.Data.SqlClient;
namespace Login_MVC.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "server=DESKTOP-R0LG4NK\\SQLEXPRESS; database=LoginsMVC; trusted_connection=true";
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Users where username = '" + acc.UserName + "' and password='" + acc.Password + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View("Create");
            } else
            {
                con.Close();
                return View("Error");
            }
        }
    }
}