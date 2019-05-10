using iTCH.COurse.WebService.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iTCH.Course.WebServices.REST.Controllers
{
    public class HomeController : ApiController
    {
        private string constr;
        private mainContext db;
        public HomeController()
        {
            constr = ConfigurationManager.AppSettings["App:DBConnection"];
            db = new mainContext(constr);
        }
        public string Get()
        {
            return "Hello world";
        }
        public string Get(int Id)
        {
            return "Get data Id: " + Id.ToString();
        }
        [HttpPost]
        public string Post(int Id)
        {
            return "Post data Id:" + Id.ToString();
        }
        [HttpPut]
        public string Put(int Id)
        {
            return "Put data Id:" + Id.ToString();
        }
        [HttpDelete]
        public string Delete(int Id)
        {
            return "Delete data Id:" + Id.ToString();
        }
    }
}
