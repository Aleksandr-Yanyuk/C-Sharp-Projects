using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces 
{
    //Interface naming conventions begin with "I" for "Interface"
    //everything is public in an interface
    interface IWalkAway
    {
        void WalkAway(Player player);
    }
}
