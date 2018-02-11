using OliverAndEmmaRSVP.Models;
using System;
using System.Web.Mvc;

namespace OliverAndEmmaRSVP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormPost(RSVP rsvp)
        {
            Boolean valid = false;

            if (ModelState.IsValid)
                valid = true;

            using (DatabaseContext context = new DatabaseContext())
            {
                Data.Entity.RSVPEntity entity = new Data.Entity.RSVPEntity
                {
                    Id = Guid.NewGuid(),
                    NumberOfGuests = rsvp.NumberOfGuests,
                    FirstName = rsvp.FirstName,
                    LastName = rsvp.LastName,
                    EMail = rsvp.EMail,
                    Questions = rsvp.Questions
                };

                context.RSVP.Add(entity);
                context.SaveChanges();
            }

            return View("Thanks");
        }
    }
}