﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_GRG_LASBATRE_LELAIDIER
{
    class PolygonePlein
    {
        private string points;

        public PolygonePlein(string points)
        {
            this.Points = points;
        }

        public string Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }
    }
}
