using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAPI.DBModel;
using WebAppAPI.Models;

namespace WebAppAPI.Controllers
{
    public class AccountController : Controller
    {
        CyberDBEntities objUserDBEntities = new CyberDBEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            UserModel objUsermodel = new UserModel();
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModel objUsermodel)
        {
            if (ModelState.IsValid)
            {
                if (!objUserDBEntities.tbl_Login.Any(m => m.Email == objUsermodel.Email))
                {


                    tbl_Login objUser = new DBModel.tbl_Login();
                    objUser.CreatedOn = DateTime.Now;
                    objUser.Email = objUsermodel.Email;
                    objUser.FirstName = objUsermodel.FirstName;
                    objUser.LastName = objUsermodel.Lastname;
                    objUser.Password = objUsermodel.Password;
                    objUserDBEntities.tbl_Login.Add(objUser);
                    objUserDBEntities.SaveChanges();
                    objUsermodel = new UserModel();
                    objUsermodel.SuccessMessage = "User is Successfully Added";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Email is Already exists");
                    return View();
                }
            }
            return View();
        }
        public ActionResult Login()
        {
            Login objloginmodel = new Login();
            return View(objloginmodel);
        }
        [HttpPost]
        public ActionResult Login( Login objloginmodel)
        {
            if(ModelState.IsValid)
            {
                if (objUserDBEntities.tbl_Login.Where(m => m.Email == objloginmodel.Email && m.Password == objloginmodel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Invalid Email and Password");
                    return View();
                }
                else
                {
                    Session["Email"] = objloginmodel.Email;
                   return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}