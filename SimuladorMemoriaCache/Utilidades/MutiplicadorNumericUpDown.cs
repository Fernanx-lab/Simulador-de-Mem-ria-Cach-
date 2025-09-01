using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMemoriaCache.Utilidades
{
    internal class MutiplicadorNumericUpDown : NumericUpDown
    {
        public override void DownButton()
        {
            if(base.Value/2 > base.Minimum)
            {
                base.Value /= 2;
            }
        }

        public override void UpButton()
        {
            if(base.Value * 2 < base.Maximum)
            {
                base.Value *= 2;
            }
        }
    }
}
