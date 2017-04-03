using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GRG_LASBATRE_LELAIDIER
{
    class Rectangle
    {
        private int x;
        private int y;
        private int l;
        private int h;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
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
                y = value;
            }
        }

        public int L
        {
            get
            {
                return l;
            }

            set
            {
                l = value;
            }
        }

        public int H
        {
            get
            {
                return h;
            }

            set
            {
                h = value;
            }
        }

        public Rectangle(int x, int y, int l, int h)
        {
            this.X = x;
            this.Y = y;
            this.L = l;
            this.H = h;
        }
    }
}
