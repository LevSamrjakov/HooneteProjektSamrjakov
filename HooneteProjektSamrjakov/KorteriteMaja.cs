using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public class KorteriteMaja : Hoone
    {
        public int KorteriteArv { get; set; }

        public List<Inimene> Elanikud { get; set; }

        public KorteriteMaja(string aadress, int pindala, Uks majaUks, int korteriteArv, EnergiaKlass energiaklass) : base(aadress, pindala, majaUks, energiaklass)
        {
            KorteriteArv = korteriteArv;
            Elanikud = new List<Inimene>();
        }

        public void LisaElanik(Inimene inimene)
        {
            if (Elanikud.Count >= KorteriteArv)
            {
                throw new InvalidOperationException(
                    "Elanike arv ei tohi ületada korterite arvu!");
            }

            Elanikud.Add(inimene);
        }

        public override double ArvutaYlalpidamiskulu()
        {
            double kulu = (Pindala * 8.0) + (KorteriteArv * 150);

            return RakendaEnergiaKordaja(kulu);
        }
    }
}
