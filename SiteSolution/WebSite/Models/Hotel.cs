using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class Hotel
    {
        public int nID { get; set; }
        public String sName { get; set; }
        public String sAddress { get; set; }
        public decimal nPrice { get; set; }
        public decimal nPenalty { get; set; }
        public String sStatusCode { get; set; }
        public String sStatusName { get; set; }
        public DateTime dCheckin { get; set; }
        public DateTime dCheckout { get; set; }
        public DateTime dWithoutCharge { get; set; }
        public String sRoomType { get; set; }
        public String sMainPassenger { get; set; }
        public int nAdults { get; set; }
        public int nChilds { get; set; }
        public int nBroker { get; set; }
    }
}