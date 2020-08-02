using System;
using Microsoft.AspNetCore.Mvc;
using PartyRSVP.Models;

namespace PartyRSVP.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() {
            return View("Index");
        }

         public ViewResult Contact() {
            return View("Contact");
        }

        public ViewResult About(){
            return View("About");
        }


        public ViewResult Projects(){
            return View("Projects");
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            // Todo: Store guest response, covered in later lessons
            return View("Thanks", guestResponse);
        }
    }
}