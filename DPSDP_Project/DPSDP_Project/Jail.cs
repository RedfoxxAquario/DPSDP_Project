using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    class Jail: State
    {
        public Jail()
        {
            this.doubleDiceCount = 0;
        }

        public override bool StateChangeCheck()
        {
            if (doubleDiceCount == 1)
            {

                Console.WriteLine(" goes out of jail after 3 turns");
                return true;
            }
            else
            {
                Console.WriteLine(" didn't made a double. He stays in jail");
                return false;
            }
        }
    }
}
