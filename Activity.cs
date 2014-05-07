using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Sunriver {
    public class Activity : WebServiceItem {
        public int srActID { get; set; }
        public string srActName { get; set; }
        public string srActDescription { get; set; }
        public DateTime srActDate { get; set; }
        public string srActTime { get; set; }
        public string srActDuration { get; set; }
        public string srActLinks { get; set; }
        public string srActUrlImage { get; set; }
        public string srActAddress { get; set; }
        public double srActLat { get; set; }
        public double srActLong { get; set; }
        public bool   isApproved { get; set; }

        protected override WebServiceItem objectFromDatasetRow(System.Data.DataRow dr) {
            Activity activity = new Activity();
            activity.srActID = Utils.ObjectToInt(dr["srActID"]);
            activity.srActName = Utils.ObjectToString(dr["srActName"]);
            activity.srActDescription = Utils.ObjectToString(dr["srActDescription"]);
            activity.srActDate = Utils.ObjectToDateTime(dr["srActDate"]);
            activity.srActTime = Utils.ObjectToString(dr["srActTime"]);
            activity.srActDuration = Utils.ObjectToString(dr["srActDuration"]);
            activity.srActLinks = Utils.ObjectToString(dr["srActLinks"]);
            activity.srActUrlImage = Utils.ObjectToString(dr["srActUrlImage"]);
            activity.srActAddress = Utils.ObjectToString(dr["srActAddress"]);
            activity.srActLat = Utils.ObjectToDouble(dr["srActLat"]);
            activity.srActLinks = Utils.ObjectToString(dr["srActLinks"]);
            activity.srActLong = Utils.ObjectToDouble(dr["srActLong"]);
            activity.isApproved=Utils.ObjectToBool(dr["isApproved"]);
            return activity;
        }
        
        public List<Activity> buildList() {
            List<Activity> list = new List<Activity>();
            foreach (DataRow dr in getDataSet().Tables[0].Rows) {
                list.Add((Activity)objectFromDatasetRow(dr));
            }
            return list;
        }
    }
}
