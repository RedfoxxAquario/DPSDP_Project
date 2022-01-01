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
            
            Random randObj = new Random();
            int dice1 = randObj.Next(1,6);
            int dice2 = randObj.Next(1,6);
            Console.WriteLine(player.name + " dices gave " + dice1 + " and " + dice2 + ".");

             if (dice1==dice2)//cas double
             {
                player.State.DoubleDiceCount ++;
                if( player.State.StateChangeCheck() == true) //Si 3 doubles -> prison
                {
                    player.State = new Jail();
                    return 40;
                }
               
             }
            else
            {
                player.State.DoubleDiceCount = 0;
            }
            player.State.TurnCount++;
            return (this.CaseNumber + dice1+dice2) % 40;

        }
        public override bool onStop(Player player)
        {
            Console.WriteLine("The player is on the position " + this.CaseNumber + " of the board.");
            return true;
        }
    }
}
