using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class SimplePosition : Position
    {

        public SimplePosition(int caseNumber) : base( caseNumber)
        {

        }

        public override int onMove(Player player)
        {
            // case 3 double dices?
            Random randObj = new Random();
            int dice1 = randObj.Next(7);
            int dice2 = randObj.Next(7);
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
            //Console.WriteLine("SimplePosition's on Move returned :", (this.CaseNumber + dice1 + dice2) % 40);

            return (this.CaseNumber + dice1+dice2) % 40;

        }
        public override bool onStop(Player player)
        {
            Console.WriteLine("The player is on the position " + this.CaseNumber + " of the board.");
            return true;
        }
    }
}
