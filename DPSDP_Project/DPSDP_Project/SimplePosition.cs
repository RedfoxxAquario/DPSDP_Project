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
            bool change=false;
            Console.WriteLine(player.name + " dices gave " + dice1 + " and " + dice2 + ".");

             if (dice1==dice2)//cas double
             {
                player.State.DoubleDiceCount ++;
                if( player.State.StateChangeCheck() == true) //Si 3 doubles -> prison
                {
                    //A READAPTER POUR NOUS POUR CHANGER DE CASE ET ALLER EN PRISON

                    //player.current = game.Cases[10];
                    //Console.WriteLine("Three doubles in a row! " + player.name + " goes to jail!");
                    //return true;
                }
               
             }
             if (!change) // sinon: il avance juste
                {
                    Console.Write(player.name + " goes from position " + player.current.CaseNumber + "(" + player.current.type + ") to position ");
                    for (int i = 0; i < dice1 + dice2; i = i + 1)
                    {
                        player.current = player.current.next;
                    }
                    Console.WriteLine(player.current.CaseNumber + "(" + player.current.type + ")");
                    player.current.stop(player, game);
             }
           
            return this.CaseNumber;
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
