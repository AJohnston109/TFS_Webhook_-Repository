using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHook
{
    public class Get_Update_Item
    {
        Get https://dev.azure.com/{organization}/{project}/_apis/wit/workitems/{id}?api-version=5.1
        

        public class Get_Work_Item
        {
            public string organization { get; set; }
            public string project { get; set; }
            public Int32 id { get; set; }
            public string fields { get; set; }
            public string asOf { get; set; }
            //public WorkItemExpand $expand{ get; set; }

           // public string api-version { get; set; }
    }
        public class Update
        {
            public string organization { get; set; }
            public string project { get; set; }
            public Int32 id { get; set; }
            public Boolean validateOnly { get; set; }
            public Boolean bypassRules { get; set; }
            public Boolean suppressNotifications { get; set; }
            //public WorkItemExpand $expand{ get; set; }

            // public string api-version { get; set; }

        }
    }
}
