using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
     static class State
    {
        public static Human ActiveWorker { get; set; }

        public static Client ActiveClient { get; set; }

        public static Schedule ActiveSchedule { get; set; }
    }
}
