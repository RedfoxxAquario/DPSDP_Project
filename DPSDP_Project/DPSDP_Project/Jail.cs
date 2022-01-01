using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    class Jail: State
    {

        

        public override bool StateChangeCheck()
        {
            if (doubleDiceCount == 1 )
            {

                Console.WriteLine("Goes out of jail after making a double");
                return true;
            }
            else if(turnCount == 3)
            {
                Console.WriteLine("Goes out of jail after 3 turns");
                return true;
            }
            else
            {
                Console.WriteLine("Didn't make a double. He stays in jail");
                return false;
            }
        }
    }
}
