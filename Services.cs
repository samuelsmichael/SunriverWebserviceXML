using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Sunriver
{
    public class Services : WebServiceItem
    {
        public int serviceID { get; set; }
        public string serviceName { get; set; }
        public string serviceWebURl { get; set; }
        public string servicePictureURL { get; set; }
        public string serviceIconURL { get; set; }
        public string serviceDescription { get; set; }
        public string servicePhone { get; set; }
        public string serviceAddress { get; set; }
        public double serviceLat { get; set; }
        public double serviceLong { get; set; }

        protected override WebServiceItem objectFromDatasetRow(System.Data.DataRow dr)
        {
            Services services = new Services();
            services.serviceID = Utils.ObjectToInt(dr["serviceID"]);
            services.serviceName = Utils.ObjectToString(dr["serviceName"]);
            services.serviceWebURl = Utils.ObjectToString(dr["serviceWebURl"]);
            services.servicePictureURL = Utils.ObjectToString(dr["servicePictureURL"]);
            services.serviceIconURL = Utils.ObjectToString(dr["serviceIconURL"]);
            services.serviceDescription = Utils.ObjectToString(dr["serviceDescription"]);
            services.servicePhone = Utils.ObjectToString(dr["servicePhone"]);
            services.serviceAddress = Utils.ObjectToString(dr["serviceAddress"]);
            services.serviceLat = Utils.ObjectToDouble(dr["serviceLat"]);
            services.serviceLong = Utils.ObjectToDouble(dr["serviceLong"]);
            
            return services;
        }

        public List<Services> buildList()
        {
            List<Services> list = new List<Services>();
            foreach (DataRow dr in getDataSet().Tables[0].Rows)
            {
                list.Add((Services)objectFromDatasetRow(dr));
            }
            return list;
        }
    }
}