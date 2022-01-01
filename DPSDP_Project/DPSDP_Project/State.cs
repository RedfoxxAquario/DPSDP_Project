using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public abstract class State
    {
        protected int doubleDiceCount; 
        protected int turnCount;

        public State()
        {
            this.doubleDiceCount = 0;
            this.turnCount = 0;
        }


        public int TurnCount
        {
            get { return this.turnCount; }
            set { this.turnCount = value; }
        }

        public int DoubleDiceCount
        {
            get { return this.doubleDiceCount; }
            set { this.doubleDiceCount = value; }
        }

        public abstract bool StateChangeCheck();

    }
}
