using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Tanks
{
    class Tank
    {
        public Image img = Tanks.Properties.Resources.tank;
        public int x, y;

        public void Run()
        {
            x = ++y;
        }
    }
}
