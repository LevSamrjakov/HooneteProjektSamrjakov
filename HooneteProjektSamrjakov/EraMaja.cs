using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public class EraMaja : Hoone
    {
        public bool OnElektriautoLaadija { get; set; }

        public EraMaja(string aadress, int pindala, Uks majaUks, bool laadija, EnergiaKlass energiaklass) : base(aadress, pindala, majaUks, energiaklass)
        {
            OnElektriautoLaadija = laadija;
        }

        public override double ArvutaYlalpidamiskulu()
        {
            double kulu = Pindala * 12.5;

            if (OnElektriautoLaadija)
            {
                kulu += 600;
            }

            return RakendaEnergiaKordaja(kulu);
        }
    }
}
