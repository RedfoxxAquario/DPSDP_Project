using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public abstract class Player
    {
        //fields
        public String name { get; set; }
        private State state;
        public Position current { get;  set; }


        //properties

        public Player(String name, Board game)
        {
            this.name = name;
            current = game.Position[0];
            this.state = new Free(this);
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
