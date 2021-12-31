using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public class GoToJailPosition : Position
    {
        public GoToJailPosition(int caseNumber) : base(caseNumber)
        {

        }
        public override int onMove(Player player)
        {
            Console.WriteLine("GoToJailPosition's on Move returned :", 40);
            return 40;

        }
        public override bool onStop(Player player)
        {
            Console.WriteLine("The player is on case 30, this is the go to jail position.");
            return false;
        }
    }
}
