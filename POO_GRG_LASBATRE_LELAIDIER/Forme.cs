using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GRG_LASBATRE_LELAIDIER
{
    class Forme
    {
        private int idElement;
        private int R;
        private int G;
        private int B;
        private int ordre;

        public Forme(int idElement, int r, int g, int b, int ordre)
        {
            this.idElement = idElement;
            R = r;
            G = g;
            B = b;
            this.ordre = ordre;
        }
    }
}
