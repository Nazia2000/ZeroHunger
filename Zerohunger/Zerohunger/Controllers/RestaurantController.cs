using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zerohunger.Database;

namespace Zerohunger.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
     
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string id, string Restuarentname)
        {
            var db = new ZeroHungerEntities();
            RestuarentTable restuarentTable = (from Restuarent in db.RestuarentTables
                                             where Restuarent.id.Equals(id) &&
                                             Restuarent.Restuarentname.Equals(Restuarentname)
                                             select Restuarent).FirstOrDefault();

            return View("Requestcollect");
        }

        public ActionResult Dashboard()
        {
            return View();
        }


     

        [HttpGet]
        public ActionResult RequestCreated()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RequestCreated(string Foodname, string foodamount)
        {
            var db = new ZeroHungerEntities();
            FoodTable foodTable = new FoodTable();
            foodTable.Foodname = Foodname;
            foodTable.foodamount = foodamount;
            
            
            db.FoodTables.Add(foodTable);
            db.SaveChanges();
           
            return RedirectToAction("RequestCollection");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = new ZeroHungerEntities();
            var ext = (from food in db.FoodTables
                       where food.id == id
                       select food).SingleOrDefault();



            db.FoodTables.Remove(ext);
            db.SaveChanges();

            return RedirectToAction("RequestCollection");

        }
        

    }
}