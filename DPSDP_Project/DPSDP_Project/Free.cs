using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    class Free : State
    {
        public Free(Player player)
        {
            this.doubleDiceCount = 0;
            this.player = player;   
        }


        public override bool StateChangeCheck(Board game)
        {

            if (doubleDiceCount == 3)
            {
                player.State = new Jail(player);
                player.current = game.Position[10];
                Console.WriteLine("Three doubles in a row! " + player.name + " goes to jail!");
                return true;
            }
            else
            {
                Console.WriteLine(player.name + " did a double. He can play again!");
                return false;
            }
        }


    }
}
