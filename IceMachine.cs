using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class IceMachine 
    {
        public int IceCubes = 10000; 
        public void MakeIce()
        {
            if (IceCubes < 10000)
            {
                IceCubes++;
            }
                
        }
    }
}
