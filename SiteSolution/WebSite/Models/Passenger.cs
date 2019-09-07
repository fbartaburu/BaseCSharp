using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class Passenger
    {
        public int nID { get; set; }
        public String sName { get; set; }
        public int nAge { get; set; }
        public String sGender { get; set; }
        public String sCitizenship { get; set; }
        public String sLanguage { get; set; }
        public String sDocument_1 { get; set; }
        public String sDocument_2 { get; set; }
    }
}