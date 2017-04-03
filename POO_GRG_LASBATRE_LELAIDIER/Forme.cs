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

        public int IdElement
        {
            get
            {
                return idElement;
            }

            set
            {
                idElement = value;
            }
        }

        public int R1
        {
            get
            {
                return R;
            }

            set
            {
                R = value;
            }
        }

        public int G1
        {
            get
            {
                return G;
            }

            set
            {
                G = value;
            }
        }

        public int B1
        {
            get
            {
                return B;
            }

            set
            {
                B = value;
            }
        }

        public int Ordre
        {
            get
            {
                return ordre;
            }

            set
            {
                ordre = value;
            }
        }

        public Forme(int idElement, int r, int g, int b, int ordre)
        {
            this.IdElement = idElement;
            R1 = r;
            G1 = g;
            B1 = b;
            this.Ordre = ordre;
        }

    }
}
