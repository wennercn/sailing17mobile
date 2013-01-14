using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace sailing17Mobile.Models {
    public class BackData {
        public bool isok { get; set; }
        public string message { get; set; }
        public XmlDocument data { get; set; }

        XmlDocument bd = new XmlDocument();

        public BackData SetData(string xml){
            bd.LoadXml(xml);
            data = bd;
            return this;
        }

        public BackData SetData(ATLDATALib.IDBDataAtl atldata) {
            if (atldata.IsOK()) {
                isok = true;
                return SetData(atldata.GetNamedXML());
            } else {
                isok = false;
                message = atldata.GetErrorinfo();
            }
            return this;
        }

        public BackData SetData(ATLDATALib.DBDataAtl atldata) {
            if (atldata.IsOK()) {
                isok = true;
                return SetData(atldata.GetNamedXML());
            } else {
                isok = false;
                message = atldata.GetErrorinfo();
            }
            return this;
        }

    }
}