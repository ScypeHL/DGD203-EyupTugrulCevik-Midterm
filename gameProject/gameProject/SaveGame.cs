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
    }
}
