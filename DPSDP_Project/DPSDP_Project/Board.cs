using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class Board
    {
        private static Board instance = null;
        private static readonly object padlock = new object();
        private Position[] Positions = new Position[40];
        
        //constructor
        public static Board Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Board();
                    }
                    return instance;
                }
            }
        }

        //properties
        public Board()
        {
            creation();
        }

        public void Game()
        {

        }

        public Position[] Position
        {
            get { return Position; }
        }

        //Creation of the Board
        private void creation()
        {         
            //a remplir
        }
    }
}
