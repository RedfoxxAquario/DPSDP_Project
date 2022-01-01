using System;

namespace DPSDP_Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            Board board = Board.Instance();
            Player joueur1 = new Player("Rodrigue");
            Player joueur2 = new Player("Benoit");

            int tour = 0;
            while (tour <= 100)
            {
                Console.WriteLine();
                if (tour % 2 == 0)
                {
                    Console.WriteLine("Turn " + tour/2);
                    mouvement(joueur1, board);
                }
                else mouvement(joueur2, board);
                tour++;
            }
            Console.WriteLine("Fin de la partie après 50 tours.");
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
