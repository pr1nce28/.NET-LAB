using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prac7.Models;

namespace prac7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            feedbackList.Add(feedback);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}