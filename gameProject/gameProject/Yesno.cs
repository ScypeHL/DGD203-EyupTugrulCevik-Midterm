using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Yesno: Game
    {
        public Yesno() 
        {

        }
        public void start()
        {
            Console.WriteLine("[Yes/Y]");
            Console.WriteLine("[No/N]");
            yesno();
        }

        void yesno()
        {
            string q1;


            q1 = Console.ReadLine();
            q1 = q1.ToLower();
            if (q1 == "yes" ^ q1 == "y")
            {
                yesnoOut = true;
            }
            else if (q1 == "no" ^ q1 == "n")
            {
                yesnoOut = false;
            }
            else if (q1 == null ^ q1 == "")
            {
                Console.WriteLine(notAnswer[rng.Next(0, 5)]);
                yesno();
            }
            else
            {
                Console.WriteLine("I dont get it");
                yesno();
            }
        }
    }
}
