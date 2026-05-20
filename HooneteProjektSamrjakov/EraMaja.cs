using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public class EraMaja : Hoone
    {
        public bool OnElektriautoLaadija;

        public EraMaja(string aadress, int pindala, Uks majaUks, bool laadija) : base(aadress, pindala, majaUks)
        {
            OnElektriautoLaadija = laadija;
        }

        public override double Ülalpidamiskulu()
        {
            double kulu = Pindala * 12.5;
            if (OnElektriautoLaadija)
            {
                kulu += 600;
            }
            return kulu;
        }
    }
}
