using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKOL_OOP1
{
    class NakladniAuto
    {
        private string spz;
        private int nosnost;

        public int Hmotnostnakladu { get; private set; }

        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
            Hmotnostnakladu = 0;
        }
        
        public void NalozNaklad(int tuna)
        {
            Hmotnostnakladu += tuna;
            if (nosnost < Hmotnostnakladu)
            {
                Hmotnostnakladu = nosnost;
            }
        }

        public void VylozNaklad(int tuna)
        {
            Hmotnostnakladu -= tuna;
            if (Hmotnostnakladu < 0)
            {
                Hmotnostnakladu = 0;
            }
        }

        public override string ToString()
        {
            return String.Format("Nakladni auto {0} ma nosnost: {1} a ma nalozeno: {2}.", spz, nosnost.ToString(), Hmotnostnakladu);
        }
    }
}
