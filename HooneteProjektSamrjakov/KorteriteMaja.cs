using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public class KorteriteMaja : Hoone
    {
        public int KorteriteArv { get; set; }

        public KorteriteMaja(string aadress, int pindala, Uks majaUks, int korteriteArv) : base(aadress, pindala, majaUks)
        {
            KorteriteArv = korteriteArv;
        }

        public override double Ülalpidamiskulu()
        {
            double kulu = (Pindala * 8.0) + (KorteriteArv * 150);
            return kulu;
        }
    }
}
