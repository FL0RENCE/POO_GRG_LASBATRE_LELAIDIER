using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GRG_LASBATRE_LELAIDIER
{
    class Texte
    {
        private int x;
        private int y;
        private string contenu;

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

        public string Contenu
        {
            get
            {
                return contenu;
            }

            set
            {
                contenu = value;
            }
        }

        public Texte(int x, int y, string contenu)
        {
            this.X = x;
            this.Y = y;
            this.Contenu = contenu;
        }
    }
}
