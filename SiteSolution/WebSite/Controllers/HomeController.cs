using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Section = "Order Details".ToUpper();

            ViewBag.lPassengers = GetPassengers().OrderBy(x => x.nID);
            ViewBag.lHotels = GetHotels().OrderBy(x => x.dCheckin);

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

        private List<Passenger> GetPassengers()
        {
            var lPassengers = new List<Passenger>();
            lPassengers.Add(new Passenger
            {
                nID = 1,
                sName = "Fabian Bartaburu",
                nAge = 28,
                sGender = "Male",
                sCitizenship = "Uruguay",
                sLanguage = "Spanish",
                sDocument_1 = "4420574-3",
                sDocument_2 = "D12345"
            });
            lPassengers.Add(new Passenger
            {
                nID = 2,
                sName = "Noe Topito",
                nAge = 28,
                sGender = "Female",
                sCitizenship = "Uruguay",
                sLanguage = "Spanish",
                sDocument_1 = "1212121-2",
                sDocument_2 = "D12344"
            });

            return lPassengers;
        }

        private List<Hotel> GetHotels()
        {
            var lHotels = new List<Hotel>();
            lHotels.Add(new Hotel
            {
                nID = 1,
                sName = "Distrikt Hotel New York City, Tapestry Collection by Hilton",
                sAddress = "Calle Falsa 123",
                nPrice = 1303m,
                nPenalty = 0m,
                sStatusCode = "AV",
                sStatusName = "Available",
                dCheckin = new DateTime(2019, 11, 10),
                dCheckout = new DateTime(2019, 11, 17),
                dWithoutCharge = new DateTime(2019, 11, 10),
                sRoomType = "1 KING BED (ODCC25)",
                sMainPassenger = "Mr. Fabian Bartaburu",
                nAdults = 2,
                nChilds = 0,
                nBroker = 99991
            });
            lHotels.Add(new Hotel
            {
                nID = 2,
                sName = "Distrikt Hotel New York City, Tapestry Collection by Hilton",
                sAddress = "Calle Falsa 123",
                nPrice = 1303m,
                nPenalty = 0m,
                sStatusCode = "XA",
                sStatusName = "Cancelled By Agent",
                dCheckin = new DateTime(2019, 11, 10),
                dCheckout = new DateTime(2019, 11, 17),
                dWithoutCharge = new DateTime(2019, 11, 10),
                sRoomType = "1 KING BED (ODCC25)",
                sMainPassenger = "Mr. Fabian Bartaburu",
                nAdults = 2,
                nChilds = 0,
                nBroker = 99992
            });
            lHotels.Add(new Hotel
            {
                nID = 3,
                sName = "Distrikt Hotel New York City, Tapestry Collection by Hilton",
                sAddress = "Calle Falsa 123",
                nPrice = 1303m,
                nPenalty = 0m,
                sStatusCode = "FP",
                sStatusName = "Full Payment",
                dCheckin = new DateTime(2019, 11, 10),
                dCheckout = new DateTime(2019, 11, 17),
                dWithoutCharge = new DateTime(2019, 11, 10),
                sRoomType = "1 KING BED (ODCC25)",
                sMainPassenger = "Mr. Fabian Bartaburu",
                nAdults = 2,
                nChilds = 0,
                nBroker = 99993
            });
            lHotels.Add(new Hotel
            {
                nID = 4,
                sName = "Distrikt Hotel New York City, Tapestry Collection by Hilton",
                sAddress = "Calle Falsa 123",
                nPrice = 1303m,
                nPenalty = 0m,
                sStatusCode = "RQ",
                sStatusName = "On Request",
                dCheckin = new DateTime(2019, 11, 10),
                dCheckout = new DateTime(2019, 11, 17),
                dWithoutCharge = new DateTime(2019, 11, 10),
                sRoomType = "1 KING BED (ODCC25)",
                sMainPassenger = "Mr. Fabian Bartaburu",
                nAdults = 2,
                nChilds = 0,
                nBroker = 99994
            });
            lHotels.Add(new Hotel
            {
                nID = 5,
                sName = "Distrikt Hotel New York City, Tapestry Collection by Hilton",
                sAddress = "Calle Falsa 123",
                nPrice = 1303m,
                nPenalty = 0m,
                sStatusCode = "KK",
                sStatusName = "Confirmed",
                dCheckin = new DateTime(2019, 11, 10),
                dCheckout = new DateTime(2019, 11, 17),
                dWithoutCharge = new DateTime(2019, 11, 10),
                sRoomType = "1 KING BED (ODCC25)",
                sMainPassenger = "Mr. Fabian Bartaburu",
                nAdults = 2,
                nChilds = 0,
                nBroker = 99995
            });

            return lHotels;
        }
    }
}