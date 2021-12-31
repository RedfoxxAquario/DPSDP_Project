using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class Player
    {
        //fields
        public String name { get; set; }
        private State state;
        public Position current { get;  set; }


        //properties

        public Player(String name)
        {
            this.name = name;
            current = new SimplePosition(0);
            this.state = new Free();
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
