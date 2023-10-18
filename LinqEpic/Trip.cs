using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEpic
{
    internal struct Trip
    {
        public int trip_no { get; set; }
        public int Id_comp { get; set; }
        public int plane { get; set; }
        public string town_from { get; set; }
        public string town_to { get; set; }
        public DateTime time_out { get; set; }
        public DateTime time_in { get; set; }


    }
        
}
