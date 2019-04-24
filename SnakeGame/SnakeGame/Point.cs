using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]

    public  class Point
   {
        int x;
        int y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = Filterx(value);
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = Filtery(value);
            }
        }
        public Point() { }
        public Point (int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Filtery(int v)
        {
            if (v < 0) v = 31;
            else if (v >= 32) v = 0;

            return v;
        }
        public int Filterx(int v)
        {
            if (v < 0) v = 78;
            else if (v >= 80) v = 0;

            return v;
        }
    }
}
