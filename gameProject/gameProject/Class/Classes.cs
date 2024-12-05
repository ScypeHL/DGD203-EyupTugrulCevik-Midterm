using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Classes: Game
    {
        int cAp;  // copy - compare
        int dAp;  // diff

        int cSp;
        int dSp;
      
        int cDp;
        int dDp;

        float cAspeed;
        float dAspeed;

        float cHp;
        float dHp;

        string cClassName;

        float overall;
        float overall1;
        float overall2;
        float overall3;
        float overall4;

        float min;

        List<float> overallCompare = new List<float>();
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

        #region classifying
        public void compare()
        {
            cAp = Ap;
            cSp = Sp;
            cDp = Dp;
            cAspeed = ASpeed;
            cHp = Hp;
            cClassName = ClassName;

            Character hunter = new Character(new Hunter(), new Dagger());
            calculate(1);
            
            Character sorcerer = new Character(new Sorcerer(), new MagicWand());
            calculate(2);

            Character archer = new Character(new Archer(), new Bow());
            calculate(3);

            Character warrior = new Character(new Warrior(), new Sword());
            calculate(4);

            Ap = cAp;
            Sp = dSp;
            Dp = cDp;
            ASpeed = cAspeed;
            Hp = cHp;
            ClassName = cClassName;

            overallCompare.Add(overall1);
            overallCompare.Add(overall2);
            overallCompare.Add(overall3);
            overallCompare.Add(overall4);

            min = overallCompare.Min();

            if (min == overall1) { Console.WriteLine("Your character is a member of Hunters clan"); }
            else if (min == overall2) { Console.WriteLine("Your character is a member of Sorcerers clan"); }
            else if (min == overall3) { Console.WriteLine("Your character is a member of Archers clan"); }
            else if (min == overall4) { Console.WriteLine("Your character is a member of Warriors clan"); }
            else { Console.WriteLine("bug"); }
        }

        private void calculate(int order)
        {
            dAp = Math.Abs(Ap - cAp);
            dSp = Math.Abs(Sp - cSp);
            dDp = Math.Abs(Dp - cDp);
            dAspeed = Math.Abs(ASpeed * 10 - cAspeed * 10);
            dHp = Math.Abs(Hp / 10 - cHp / 10);

            overall = dAp + dSp + dDp + dAspeed + dHp;

            switch (order)
            {
                case 1:
                    overall1 = overall;
                    break;
                case 2:
                    overall2 = overall;
                    break;
                case 3:
                    overall3 = overall;
                    break;
                case 4:
                    overall4 = overall;
                    break;
            }
        }
        #endregion
    }
}
