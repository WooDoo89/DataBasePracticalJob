﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    abstract class Human
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
    }
}
