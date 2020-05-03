using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    class Admin : Human
    {
        public Place place { get; set; }

        protected static Admin a;
        protected static int thisAdminID;
        public void SetList(Admin A)
        {
            a = A;
        }
        public Admin GetList()
        {
            return a;
        }
        public void SetID(int id)
        {
            thisAdminID = id;
        }
        public int GetID()
        {
            return thisAdminID;
        }
    }
}
