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
        Weapons weapons = new Weapons();
        public Character(Classes Classes, Weapons Weapons)
        {
            classes = Classes;
            weapons = Weapons;
        }

        public void Class()
        {
            classes.start();
        }

        public void Weapon()
        {
            weapons.start();
        }
    }
}
