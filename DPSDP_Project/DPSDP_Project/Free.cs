using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    class Free : State
    {
        public Free()
        {
            this.doubleDiceCount = 0;
        }


        public override bool StateChangeCheck()
        {

            if (doubleDiceCount == 3)
            {
                Console.WriteLine("Three doubles in a row! " ," goes to jail!");
                return true;
            }
            else
            {
                Console.WriteLine(" did a double. He can play again!");
                return false;
            }
        }


    }
}
