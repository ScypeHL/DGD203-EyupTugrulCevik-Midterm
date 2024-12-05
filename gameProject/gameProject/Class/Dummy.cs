using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Dummy: Classes
    {
        public Dummy()
        {
            ClassName = "Dummy";
            Ap = 8;
            Sp = 10;
            Dp = 10;
            ASpeed = 1f;
            Hp = 100;
        }
    }
}
