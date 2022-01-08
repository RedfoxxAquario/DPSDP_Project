using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class Board
    {
        private static Board instance = null;
        private static readonly object padlock = new object();
        private Position[] positions = new Position[41];

        //constructors
        public static Board Instance()
        {

                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Board();
                    }
                    else
                    {
                        throw new Exception("Only one board can be created");
                    }
                    return instance;
                }
            
        }
        private Board()
        {

            for (int i = 0; i < this.positions.Length; i = i + 1)
            {
                if (i == 40) this.positions[i] = new JailPosition(i);
                else if (i == 30) this.positions[i] = new GoToJailPosition(i);
                else this.positions[i] = new SimplePosition(i);

            }
        }

        //properties
        public Position[] Positions
        {
            get { return positions; }
        }

    }
}
