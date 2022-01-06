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
            int dice1 = randObj.Next(1,7);
            int dice2=randObj.Next(1,7);
            Console.WriteLine("The player's dices gave " + dice1 + " and "+dice2+".");

            
            if (dice1==dice2)//cas double
            {
                player.State.DoubleDiceCount += 1;
                if (player.State.StateChangeCheck()) //cas double
                {
                    //Console.WriteLine("The player did 1 double and is going out of prison.");
                    player.State = new Free();

                    return (10+dice1+dice2)%40;
                }
            }

            player.State.TurnCount++;


            if(player.State.StateChangeCheck())
            {
                //Console.WriteLine("The player did 3 turns and is going out of prison.");
                player.State = new Free();

                return (10 + dice1 + dice2) % 40;
            }
            return this.CaseNumber;

        }
        public override bool onStop(Player player)
        {
            if(player.State.GetType()==typeof(Free))
            {
                Console.WriteLine("He was free and now is in jail");
                player.State = new Jail();
            }
            else
            {
                Console.WriteLine("The player remains in jail for the " + (player.State.TurnCount+1) + "th turn.");

            }
            return true;
        }
    }
}
