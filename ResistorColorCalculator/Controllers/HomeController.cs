using ResistorColorCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ResistorColorCalculator.Models.ValueFetcher;

namespace ResistorColorCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Resistor res = new Resistor();
            ViewBag.DigitColors = new SelectList(Enum.GetValues(typeof(BandDigitEnum)).Cast<BandDigitEnum>());
            ViewBag.MultiplierColors = new SelectList(res.GetBandMultiplierColor());
            ViewBag.TolleranceColor = new SelectList(res.GetBandToleranceColor(), "Value", "Key");
            return View(res);
        }
        [HttpPost]
        public ActionResult Index(Resistor res)
        {
            ViewBag.DigitColors = new SelectList(Enum.GetValues(typeof(BandDigitEnum)).Cast<BandDigitEnum>());
            ViewBag.MultiplierColors = new SelectList(res.GetBandMultiplierColor());
            ViewBag.TolleranceColor = new SelectList(res.GetBandToleranceColor(), "Value", "Key");
            if (ModelState.IsValid)
            {
                // I4BandRes res = new Resistor();
                
                return View(res);
            }
            return View(new Resistor());
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
    }
}