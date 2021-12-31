using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public abstract class State
    {
        protected int doubleDiceCount = 0; //protected ?

        public State()
        {

        }
        public int DoubleDiceCount
        {
            get;
            set;
        }

        public abstract bool StateChangeCheck();

    }
}
