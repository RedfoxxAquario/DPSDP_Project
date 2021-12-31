using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class JailPosition : Position
    {
        public JailPosition(int caseNumber) : base(caseNumber)
        {

        }

        public override int onMove(Player player)
        {
            //know the double dice count? give Position a player ? or a doubleDiceCount

            Random randObj = new Random();
            int dice1 = randObj.Next(7);
            int dice2=randObj.Next(7);
            Console.WriteLine("The player's dices gave " + dice1 + " and "+dice2+".");

            
            if (dice1==dice2)//cas double
            {
                player.State.DoubleDiceCount += 1;
                if (player.State.StateChangeCheck()) //cas 3 doubles à la suite
                {
                    Console.WriteLine("The player did 1 double and is going out of prison.");
                    player.State = new Free();
                    //Console.WriteLine("Jail Position's on Move returned :", (10 + dice1 + dice2) % 40);

                    return (10+dice1+dice2)%40;
                }
            }
            //Console.WriteLine("Jail Position's on MOve returned :", this.CaseNumber);
            return this.CaseNumber;

        }
        public override bool onStop(Player player)
        {
            player.State = new Jail();
            Console.WriteLine("The player is in jail.");
            return true;
        }
    }
}
