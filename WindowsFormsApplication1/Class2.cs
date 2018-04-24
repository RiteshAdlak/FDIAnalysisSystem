using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace WindowsFormsApplication1
{
    class Class2
    {


        public ObjectId _id { get; set; }
        public int year { get; set; }
        public string sname { get; set; }
        public string region { get; set; } 
        public int total { get; set; }
        public string state_id { get; set; }




      public int tour { get; set; }
        public int edu { get; set; }
        public int trans { get; set; }
        public int ftrade { get; set; }
        public int infr { get; set; }
        public int glob { get; set; }

        public int serv { get; set; }
        public int res { get; set; }

        public int oth { get; set; }
        public int pow { get; set; }


        internal object Remove(MongoDB.Driver.IMongoQuery iMongoQuery)
        {
            throw new NotImplementedException();
        }
    }
}
