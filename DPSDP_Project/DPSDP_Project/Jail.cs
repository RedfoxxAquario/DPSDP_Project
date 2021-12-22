using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    class Jail: State
    {
        public Jail(Player player)
        {
            this.doubleDiceCount = 0;
            this.player = player;
        }

        public override bool StateChangeCheck(Board game)
        {
            if (doubleDiceCount == 3)
            {
                player.State = new Free(player);
                doubleDiceCount = 0;
                Console.WriteLine(player.name + " goes out of jail after 3 turns");
                return true;
            }
            else
            {
                Console.WriteLine(player.name + " didn't made a double. He stays in jail");
                return false;
            }
        }
    }
}
