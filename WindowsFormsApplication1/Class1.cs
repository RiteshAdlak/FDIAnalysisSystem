using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public ObjectId _id { get; set; }
        public int year { get; set; }
        public string sname { get; set; }
        public string region { get; set; }
        public string state_id { get; set; }

        public string state_name { get; set; }


        public int tour { get; set; }
    }
}
