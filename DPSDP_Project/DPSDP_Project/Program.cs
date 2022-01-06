using System;

namespace DPSDP_Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            Board board = Board.Instance();
            Player joueur1 = new Player("Audrey");
            Player joueur2 = new Player("Lisa");

            int tour = 0;
            Console.WriteLine("Welcome to our Monopoly. Press enter to start.");

            while (tour <= 100)
            {
                Console.WriteLine();
                if (tour % 2 == 0)
                {
                    Console.ReadKey();

                    Console.WriteLine("Turn " + tour/2);
                    mouvement(joueur1, board);

                }
                else mouvement(joueur2, board);
                tour++;
            }
            Console.WriteLine("End of the game after 50 turns" +
                ".");
        }


        public static void mouvement(Player player, Board jeu)
        {
            //Console.WriteLine("Before turn, the player is on position "+ player.Current.CaseNumber);
            player.Current=jeu.Positions[player.Current.onMove(player)];
            //Console.WriteLine("After turn, the player is on position "+ player.Current.CaseNumber);

            if (player.Current.onStop(player) ==false )
            {
                mouvement(player, jeu);
            }
            else if(player.State.DoubleDiceCount>0)
            {
                Console.WriteLine("New turn for the player.");
                mouvement(player, jeu);

            }

        }
    }

}
