using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    class Schedule
    {
        private int ID { get; set; }
        private Client client { get; set; }
        private Instructor instructor { get; set; }
        private Admin Admin { get; set; }
        private Plane plane { get; set; }
        private string date { get; set; }
    }
}
