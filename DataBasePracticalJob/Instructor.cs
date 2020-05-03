using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    class Instructor : Human
    {
        public Place place { get; set; }

        protected static Instructor i;
        protected static int thisInstructorID;
        public void SetList(Instructor I)
        {
            i = I;
        }
        public Instructor GetList()
        {
            return i;
        }
        public void SetID(int id)
        {
            thisInstructorID = id;
        }
        public int GetID()
        {
            return thisInstructorID;
        }
    }
}
