using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Sunriver
{
    public class Welcome : WebServiceItem
    {
        public int welcomeID { get; set; }
        public string welcomeURL { get; set; }


        protected override WebServiceItem objectFromDatasetRow(System.Data.DataRow dr)
        {
            Welcome welcome = new Welcome();
            welcome.welcomeID = Utils.ObjectToInt(dr["welcomeID"]);
            welcome.welcomeURL = Utils.ObjectToString(dr["welcomeURL"]);
            return welcome;
        }

        public List<Welcome> buildList()
        {
            List<Welcome> list = new List<Welcome>();
            foreach (DataRow dr in getDataSet().Tables[0].Rows)
            {
                list.Add((Welcome)objectFromDatasetRow(dr));
            }
            return list;
        }
    }
}