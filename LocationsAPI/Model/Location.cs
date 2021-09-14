using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationsAPI.Model
{
    public class Location
    {
        public int id { get; set; }
        public decimal latitude { get; set; }

        public decimal longitude { get; set; }
        public string carOwnerID { get; set; }

        public string postID { get; set; }

        public long timestamp { get; set; }
        
    }
}
