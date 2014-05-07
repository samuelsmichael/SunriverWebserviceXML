using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Sunriver
{
    public class Update : WebServiceItem
    {
        public int updateID { get; set; }
        public DateTime updateCalendar { get; set; }
        public DateTime updateActivity { get; set; }
        public DateTime srActDate { get; set; }
        public DateTime updateMaps { get; set; }
        public DateTime updateServices { get; set; }
        public DateTime updateWelcome { get; set; }
        public DateTime updateData { get; set; }

        protected override WebServiceItem objectFromDatasetRow(System.Data.DataRow dr)
        {
            Update update = new Update();
            update.updateID = Utils.ObjectToInt(dr["updateID"]);
            update.updateCalendar = Utils.ObjectToDateTime(dr["updateCalendar"]);
            update.updateActivity = Utils.ObjectToDateTime(dr["updateActivity"]);
            update.updateMaps = Utils.ObjectToDateTime(dr["updateMaps"]);
            update.updateServices = Utils.ObjectToDateTime(dr["updateServices"]);
            update.updateWelcome = Utils.ObjectToDateTime(dr["updateWelcome"]);
            update.updateData = Utils.ObjectToDateTime(dr["updateData"]);
            return update;
        }

        public List<Update> buildList()
        {
            List<Update> list = new List<Update>();
            foreach (DataRow dr in getDataSet().Tables[0].Rows)
            {
                list.Add((Update)objectFromDatasetRow(dr));
            }
            return list;
        }
    }
}