using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace WebHook
{
    public class Create_Delete
    {
        public object Id;
        public object Status;
        public object From;
        public object Description;
        public object Assigned_to;
        public object Effort;


        public class Tfs_Input
        {
            public int Id { get; set; }
            public string Status { get; set; }
            public string From { get; set; }
            public string Description { get; set; }
            public string Assigned_to { get; set; }
            public int Effort { get; set; }

        }
        public class Create
        {
            public string from { get; set; }
            public Operation op { get; set; }
            public string path { get; set; }
            public object value { get; set; }

        }
        public class Delete
        {
            public string organization { get; set; }
            public string project { get; set; }
            public Int32 id { get; set; }
            public Boolean destroy { get; set; }
           // public string api-Version { get; set; }
    }

        //string json = JsonConvert.SerializeObject(input);
        //public override string ToString()
        //{
        //    return string.Format("Information:\n\tId:{0}Status:{1}\n\tFrom:{2}\n\tDescription{3}\n\tAssigned_to:{4}\n\tEffort:{5}",
        //        Id, Status, From, Description, Assigned_to, Effort);
        //}
    }
}
