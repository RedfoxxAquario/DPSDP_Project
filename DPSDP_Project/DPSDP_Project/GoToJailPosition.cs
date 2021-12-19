using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class GoToJailPosition : Position
    {
        public override int onMove(Player player)
        {
            return -1;

        }
        public override bool onStop()
        {
            Console.WriteLine("The player is on case 30, this is the go to jail position.");
            return false;
        }
    }
}
