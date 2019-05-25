using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Enforcement_System
{
    class Violator
    {
        public string Enforcer { get; set; }
        public string TVBNo { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string to { get; set; }
        public string licenseNo { get; set; }
        public string address1 { get; set; }
        public string plateNo { get; set; }
        public string make { get; set; }
        public string color { get; set; }
        public string owner { get; set; }
        public string address2 { get; internal set; }
        public string violation { get; internal set; }
        public string Location { get; set; }
        public string Price { get; set; }
    }
   
}
