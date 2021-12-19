using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public abstract class Position:MovingBehaviour
    {
        protected int caseNumber;
        public Position() { }
        public Position(int CaseNumber)
        {
            this.caseNumber = CaseNumber;
        }

        public virtual int onMove(Player player) { return -3; }
        public virtual bool onStop() { return true; }
    }
}
