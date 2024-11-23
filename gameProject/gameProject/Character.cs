using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Character: Game
    {
        Classes classes = new Classes();
        public Character(Classes Classes)
        {
            classes = Classes;

        }

        public void start()
        {
            classes.start();
        }
    }
}
