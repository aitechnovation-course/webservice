using iTCH.COurse.WebService.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace iTCH.Course.WebService.SOAP
{
    /// <summary>
    /// Summary description for ExampleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ExampleService : System.Web.Services.WebService
    {
        private string constr;
        private mainContext db;
        public ExampleService()
        {
            constr = ConfigurationManager.AppSettings["App:DBConnection"];
            db = new mainContext(constr);
        }
        [WebMethod]
        public string HelloWorld()
        {
            int tmp = db.Person.Count();
            return "Hello World";
        }
    }
}
