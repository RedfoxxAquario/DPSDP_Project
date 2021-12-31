﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public abstract class Position:MovingBehaviour
    {
        private int caseNumber;
        public Position() { }
        public Position(int CaseNumber)
        {
            this.caseNumber = CaseNumber;
        }

        public int CaseNumber
        {
            get;
            set;
        }


        public abstract int onMove(Player player);
        public abstract bool onStop(Player player);
    }
}
