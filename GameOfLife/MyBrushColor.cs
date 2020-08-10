using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class MyBrushColor
    {
        public int Red;
        public int Green;
        public int Blue;
        public MyBrushColor(int Red, int Green, int Blue)
        {
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
        }
    }
}
