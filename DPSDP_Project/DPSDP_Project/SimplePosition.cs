using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class SimplePosition : Position
    {
        public override int onMove(Player player)
        {
            // case 3 double dices?
            Random randObj = new Random();
            int dice1 = randObj.Next();
            int dice2 = randObj.Next();
            Console.WriteLine("The player's dices gave " + dice1 + " and " + dice2 + ".");

            /*
            if (dice1 % 2 == 0 && dice2 % 2 == 0)//cas double
            {
                player.state.doubleDiceCount += 1;
                if (player.state.StateChangeCheck) //cas 3 doubles à la suite
                {
                    Console.WriteLine("The player did 3 doubles in a row and is going to prison.");
                    return -1;
                }
            }
            */
            return (this.caseNumber + dice1+dice2) % 40;

        }
        public override bool onStop()
        {
            Console.WriteLine("The player is on the position " + this.caseNumber + " of the board.");
            return true;
        }
    }
}
