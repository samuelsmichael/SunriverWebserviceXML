using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;

namespace Sunriver
{
    public class Alert : WebServiceItem
    {
        public int ALID { get; set; }
        public string ALTitle { get; set; }
        public string ALDescription { get; set; }

        protected override WebServiceItem objectFromDatasetRow(System.Data.DataRow dr)
        {
            Alert alert = new Alert();
            alert.ALID = Utils.ObjectToInt(dr["ALID"]);
            alert.ALTitle = Utils.ObjectToString(dr["ALTitle"]);
            alert.ALDescription = Utils.ObjectToString(dr["ALDescription"]);
            return alert;
        }

        public List<Alert> buildList()
        {
            List<Alert> list = new List<Alert>();
            foreach (DataRow dr in getDataSet().Tables[0].Rows)
            {
                list.Add((Alert)objectFromDatasetRow(dr));
            }
            return list;

        }

    }
}