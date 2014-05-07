using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Sunriver {
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService {

        [WebMethod]
        public List<Calendar> Calendar() {
            return new Calendar().buildList();
        }
        [WebMethod]
        public List<Map> Map() {
            return new Map().buildList();
        }
        [WebMethod]
        public List<Activity> Activity() {
            return new Activity().buildList();
        }
        [WebMethod]
        public CountyAddress FindCountyAddress(string resortAddress) {
            try {
                return new CountyAddress(resortAddress);
            } catch {
                return null;
            }
        }

        [WebMethod]
        public List<Alert> Alert() {
            return new Alert().buildList();
        }
        [WebMethod]
        public List<Welcome> Welcome()
        {
            return new Welcome().buildList();
        }
        [WebMethod]
        public List<Update> Update()
        {
            return new Update().buildList();
        }
        [WebMethod]
        public List<Services> Services()
        {
            return new Services().buildList();
        }
    }
}
