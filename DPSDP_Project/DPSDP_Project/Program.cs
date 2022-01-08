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

            int turn = 0;
            Console.WriteLine("Welcome to our Monopoly. Press enter to start.");

            while (turn <= 100)
            {
                Console.WriteLine();
                if (turn % 2 == 0)
                {
                    Console.ReadKey();

                    Console.WriteLine("Turn " + turn / 2);
                    Turn(joueur1, board);

                }
                else Turn(joueur2, board);
                turn++;
            }
            Console.WriteLine("End of the game after 50 turns" +
                ".");
        }


        public static void Turn(Player player, Board jeu)
        {
            //Console.WriteLine("Before turn, the player is on position "+ player.Current.CaseNumber);
            player.Current=jeu.Positions[player.Current.onMove(player)];
            //Console.WriteLine("After turn, the player is on position "+ player.Current.CaseNumber);

            if (player.Current.onStop(player) ==false )
            {
                Turn(player, jeu);
            }
            else if(player.State.DoubleDiceCount>0)
            {
                Console.WriteLine("New turn for the player.");
                Turn(player, jeu);

            }

        }
    }

}
