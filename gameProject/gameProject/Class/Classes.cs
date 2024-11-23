using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Classes: Game
    {
        public Classes() 
        {
        }

        public void start()
        {
            printStats();
        }
        public void printStats()
        {
            Console.WriteLine($"[{ClassName}] > Health:{Hp} | Attack:{Ap} | Skill:{Sp} | Defense: {Dp} | Attack Speed:{ASpeed}");
        }
    }
}
