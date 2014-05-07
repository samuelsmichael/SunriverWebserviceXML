using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Sunriver {

    public class Calendar : WebServiceItem {
        public int srCalId { get; set; }
        public string srCalName { get; set; }
        public string srCalDescription { get; set; }
        public DateTime srCalDate { get; set; }
        public string srCalTime { get; set; }
        public string srCalDuration { get; set; }
        public string srCalLinks { get; set; }
        public string srCalUrlImage { get; set; }
        public string srCalAddress { get; set; }
        public double srCalLat { get; set; }
        public double srCalLong { get; set; }
        public bool isApproved { get; set; }

        protected override WebServiceItem objectFromDatasetRow(System.Data.DataRow dr) {
            Calendar calendar = new Calendar();
            calendar.srCalId = Utils.ObjectToInt(dr["srCalID"]);
            calendar.srCalAddress = Utils.ObjectToString(dr["srCalAddress"]);
            calendar.srCalDate = Utils.ObjectToDateTime(dr["srCalDate"]);
            calendar.srCalDuration = Utils.ObjectToString(dr["srCalDuration"]);
            calendar.srCalLat = Utils.ObjectToDouble(dr["srCalLat"]);
            calendar.srCalDescription = Utils.ObjectToString(dr["srCalDescription"]);
            calendar.srCalLinks = Utils.ObjectToString(dr["srCalLinks"]);
            calendar.srCalName = Utils.ObjectToString(dr["srCalName"]);
            calendar.srCalLong = Utils.ObjectToDouble(dr["srCalLong"]);
            calendar.srCalTime = Utils.ObjectToString(dr["srCalTime"]);
            calendar.srCalUrlImage = Utils.ObjectToString(dr["srCalUrlImage"]);
            calendar.isApproved=Utils.ObjectToBool(dr["isApproved"]);
            return calendar;
        }

        public List<Calendar> buildList() {
            List<Calendar> list = new List<Calendar>();
            foreach (DataRow dr in getDataSet().Tables[0].Rows) {
                list.Add((Calendar)objectFromDatasetRow(dr));
            }
            return list;
        }  
    }
}
