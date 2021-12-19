using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class JailPosition : Position
    {
        public override int onMove(Player player)
        {
            //know the double dice count? give Position a player ? or a doubleDiceCount

            Random randObj = new Random();
            int dice1 = randObj.Next();
            int dice2=randObj.Next();
            Console.WriteLine("The player's dices gave " + dice1 + " and "+dice2+".");

            /*
            if (dice1 % 2 == 0 && dice2 % 2 == 0)//cas double
            {
                player.state.doubleDiceCount += 1;
                if (player.state.StateChangeCheck) //cas 3 doubles à la suite
                {
                    Console.WriteLine("The player did 1 doubles and is going out of prison.");
                    return -1;
                }
            }
            */

            if (dice1%2==0 && dice2%2==0) //case the player does a double or it's his 3rd turnand goes out
            {
                return (10 + dice1 + dice2) % 40;
            }
            return this.caseNumber;

        }
        public override bool onStop()
        {
            Console.WriteLine("The player is in jail.");
            return true;
        }
    }
}
