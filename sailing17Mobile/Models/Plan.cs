using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sailing17Mobile.Models
{
    public class Plan{
        public string sn { set; get; }
        public string plan_id { set; get; }
        public string cname{ set; get; }
        public string ename { set;get; }
        public string imo_code { set; get; }
        public string eta1 { set; get; }
        public string etb1 { set; get; }
        public string etd1 { set; get; }
        public string voyage_num { set;get; }
    }
}