using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    class Pilot : Human
    {
        public Place place { get; set; }

        protected static Pilot p;
        protected static int thisPilotID;
        public void SetList(Pilot P)
        {
            p = P;
        }
        public Pilot GetList()
        {
            return p;
        }
        public void SetID(int id)
        {
            thisPilotID = id;
        }
        public int GetID()
        {
            return thisPilotID;
        }
    }
}
