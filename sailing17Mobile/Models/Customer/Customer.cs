using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sailing17Mobile.Models.Customer {
    public class Customer {
        public string title {set;get;}
        public string ntype {set;get;}
        public string new_id {set;get;}
        public string newcontent {set;get;}
        public string fullname {set;get;}
        public string emp_id {set;get;}
        public string customer_id {set;get;}
        public string customer_code {
            set { }
            get { return ntype; } 
        }
        public string customer_name {
            set { }
            get { return title; } 
        }
    }
}