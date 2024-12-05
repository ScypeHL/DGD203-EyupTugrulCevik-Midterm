using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Weapons: Game
    {
        public static int aap;
        public static int asp;
        public static float aaspeed;

        public Weapons()
        {
            Ap = Ap + aap;
            Sp = Sp + asp;
            ASpeed = ASpeed + aaspeed;
        }
        public void start()
        {
        }
    }
}
