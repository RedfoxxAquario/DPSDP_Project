using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project
{
    public interface MovingBehaviour
    {

        public virtual int onMove(Player player) { return -2; }
        public virtual bool onStop(Player player) { return true; }
        
    }
}
