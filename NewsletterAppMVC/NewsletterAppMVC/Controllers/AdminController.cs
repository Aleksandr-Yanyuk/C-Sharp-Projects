using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //gives access to the database, instantiates it as db object
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //SignUps represents all records in database, instantiates it as signups
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                //using linq for the same function as line 20
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                //creates list of View Models
                var signupVms = new List<SignupVm>();
                //loops through Vm's and map them to a view model
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";
            ////initializes list as an empty list
            //List<NewsletterSignup> signups = new List<NewsletterSignup>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignup();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

            //        signups.Add(signup);
            //    }
            //}
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //finds record we want with the primary key "id"
                var signup = db.SignUps.Find(Id);
                //changes the removed property in record
                signup.Removed = DateTime.Now;
                //updates to actual db
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}