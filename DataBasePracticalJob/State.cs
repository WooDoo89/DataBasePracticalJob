using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
     static class State
    {
        public static Admin ActiveAdmin { get; set; }
        public static Pilot ActivePilot { get; set; }
        public static Instructor ActiveInstructor { get; set; }
        public static Client ActiveClient { get; set; }
    }
}
