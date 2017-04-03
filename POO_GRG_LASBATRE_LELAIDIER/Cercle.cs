using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GRG_LASBATRE_LELAIDIER
{
    class Cercle
    {
        private int cx;
        private  int cy;
        private int r;

        public Cercle(int cx, int cy, int r)
        {
            this.Cx = cx;
            this.Cy = cy;
            this.R = r;
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

        public int R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }
    }
}
