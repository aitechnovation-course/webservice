using iTCH.COurse.WebService.Database;
using iTCH.COurse.WebService.Database.Models;
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
        public List<Person> Get()
        {
            return db.Person.ToList();
        }
        public Person Get(int Id)
        {
            return db.Person.Find(Id);
        }
        [HttpPost]
        public string Post(Person ob)
        {
            db.Person.Add(ob);
            db.SaveChanges();
            return "Post data Id:" + ob.Id;
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
