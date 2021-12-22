using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public abstract class State
    {
        protected int doubleDiceCount = 0; //protected ?
        protected Player player;  //ou protected ?


        public State()
        {

        }

        public abstract bool StateChangeCheck(Board game);

    }
}
