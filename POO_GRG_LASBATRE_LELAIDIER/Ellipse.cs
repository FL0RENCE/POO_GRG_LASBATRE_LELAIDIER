using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GRG_LASBATRE_LELAIDIER
{
    class Ellipse
    {
        private int cx;
        private int cy;
        private int rx;
        private int ry;

        public Ellipse(int cx, int cy, int rx, int ry)
        {
            this.Cx = cx;
            this.Cy = cy;
            this.Rx = rx;
            this.Ry = ry;
        }

        public int Cx
        {
            get
            {
                return cx;
            }

            set
            {
                cx = value;
            }
        }

        public int Cy
        {
            get
            {
                return cy;
            }

            set
            {
                cy = value;
            }
        }

        public int Rx
        {
            get
            {
                return rx;
            }

            set
            {
                rx = value;
            }
        }

        public int Ry
        {
            get
            {
                return ry;
            }

            set
            {
                ry = value;
            }
        }
    }
}
