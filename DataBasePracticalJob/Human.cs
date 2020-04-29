using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    abstract class Human
    {
        private int ID { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private string email { get; set; }
        private string mobileNumber { get; set; }
    }
}
