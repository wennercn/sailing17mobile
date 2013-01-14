using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using sailing17Mobile.Models;

namespace sailing17Mobile.Controllers
{
    public class ApiUserController : ApiController
    {
        //返回的数据
        BackData bd = new BackData {
            isok = true , 
            message = ""
        };

        // GET api/values
        public BackData Get(){
            //return new string[] { "value1", "value2" };
            return bd.SetData("<rowset><r a=\"aaa\"/></rowset>");
        }

        // GET api/values/5
        public BackData Get(int id){
            ATLDATALib.IDBDataAtl rs = new ATLDATALib.DBDataAtl();
            rs.InsertString("111");
            bd.message = "121212";// rs.GetNamedXML();
            return bd;//bd.SetData(rs);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}