using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    class SaveGame: Game
    {
        StreamWriter saveWrite = new StreamWriter("saves.txt");

        int rAp;
        int rSp;
        int rDp;
        float rAspeed;
        float rHp;

        public SaveGame()
        {

        }

        public void save()
        {
            saveWrite.WriteLine(Ap);
            saveWrite.WriteLine(Sp);
            saveWrite.WriteLine(Dp);
            saveWrite.WriteLine(ASpeed);
            saveWrite.WriteLine(Hp);
            saveWrite.WriteLine(Name);
            saveWrite.WriteLine(ClassName);
            saveWrite.WriteLine(Xp);
            saveWrite.Close();
        }

        public void load()
        {
            //rAp = Convert.ToInt16(saveRead.ReadLine());
            //rSp = Convert.ToInt16(saveRead.ReadLine());
            //rDp = Convert.ToInt16(saveRead.ReadLine());
            //rAspeed = (float) Convert.ToDouble(saveRead.ReadLine());
            //rHp = (float) Convert.ToDouble(saveRead.ReadLine());
        }
    }
}
