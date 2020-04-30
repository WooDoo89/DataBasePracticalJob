using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    class Order
    {
        private int ID { get; set; }
        private Admin admin { get; set; }
        private Pilot pilot { get; set; }
        private Instructor instructor { get; set; }
        private Coupon coupon { get; set; }
        private Schedule schedule { get; set; }
        private Plane plane { get; set; }
        private Client client { get; set; }
        private JumpType jumpType { get; set; }
        private Equipment equipment { get; set; }
        private int peopleNumber { get; set; }
        private string status { get; set; }
    }
}
