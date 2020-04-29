using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    class Client : Human
    {
        private Archyve archyve { get; set; }
        private Admin admin { get; set; }
        private float weight { get; set; }
        private float height { get; set; }
    }
}
