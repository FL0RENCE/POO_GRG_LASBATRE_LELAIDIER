using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GRG_LASBATRE_LELAIDIER
{
    class Chemin
    {
        private string path;

        public Chemin(string path)
        {
            this.Path = path;
        }

        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }
    }
}
