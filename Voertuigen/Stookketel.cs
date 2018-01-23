using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Stookketel : IVervuiler
    {
        public Stookketel(float coNorm)
        {
            this.CoNorm = coNorm;
        }

        private float coNormValue;
        public float CoNorm
        {
            get
            {
                return coNormValue;
            }
            set
            {
                if (value > 0)
                    coNormValue = value;
            }
        }

        public double GeefVervuiling()
        {
            return CoNorm * 100;
        }
    }
}
