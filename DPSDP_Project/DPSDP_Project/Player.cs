using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class Player
    {
        //fields
        public String name;
        public State state;
        public Position current;



        public Player(String name)
        {
            this.name = name;
            current = new SimplePosition(0);
            this.state = new Free();
        }

        //properties

        public State State
        {
            get { return state; }
            set { this.state = value; }
        }
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Position Current
        {
            get { return this.current; }
            set { this.current = value; }
        }
    }
}
