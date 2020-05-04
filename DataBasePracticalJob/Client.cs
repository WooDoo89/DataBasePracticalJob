using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
     class Client : Human
    {
        public int admin { get; set; }
        public double weight { get; set; }
        public double height { get; set; }

        protected static Client c;
        protected static int thisClientID;
        public void SetList(Client C)
        {
            c = C;
        }
        public Client GetList()
        {
            return c;
        }
        public void SetID(int id)
        {
            thisClientID = id;
        }
        public int GetID()
        {
            return thisClientID;
        }
    }
}
