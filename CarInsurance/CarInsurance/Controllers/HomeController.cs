using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        public ActionResult Index()
        {
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

        public void CalculateQuote()
        {
            int startingQuote = 50;
            float finalQuote = 0f;

            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                foreach (var insuree in insurees)
                {
                    //int age = Convert.ToInt32(DateTime.Now - (DateTime)insuree.DateOfBirth);
                    int age = (int)(DateTime.Now - (DateTime)insuree.DateOfBirth).TotalDays;
                    age = (age / 365);
                    if (age < 18)
                    {
                        finalQuote = startingQuote + 100;
                    }
                    else if (age > 19 && age < 25)
                    {
                        finalQuote = startingQuote + 50;
                    }
                    else
                    {
                        finalQuote = startingQuote + 25;
                    }

                    int year = insuree.CarYear;
                    string make = insuree.CarMake.ToString();
                    string model = insuree.CarModel.ToString();

                    if (year < 2000)
                    {
                        finalQuote = finalQuote + 25;
                    }
                    if (year > 2015)
                    {
                        finalQuote = finalQuote + 25;
                    }
                    if (make == "Porsche")
                    {
                        finalQuote = finalQuote + 25;
                        if (model == "911 Carrera")
                        {
                            finalQuote += 25;
                        }
                    }
                    for (int i = 0; i < insuree.SpeedingTickets; i++)
                    {
                        finalQuote += 10;
                    }

                    bool violation = insuree.DUI;
                    if (violation)
                    {
                        finalQuote = finalQuote + (finalQuote * .25f);
                    }
                    bool coverage = insuree.Coverage_Type;
                    if (coverage)
                    {
                        finalQuote = finalQuote + (finalQuote * .5f);
                    }

                    insuree.Quote = Convert.ToDecimal(finalQuote);
                    
                    
                }
                db.SaveChanges();
            }
            
            
            
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Welcome to the administraton page. ";
            CalculateQuote();
            return View(db.Insurees.ToList());
        }
    }
}