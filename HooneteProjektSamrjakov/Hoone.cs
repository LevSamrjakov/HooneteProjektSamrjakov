using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public abstract class Hoone
    {
        public static int ParinguteArv = 0;

        public string Aadress { get; set; }

        public int Pindala { get; set; }

        public Uks MajaUks { get; set; }

        public EnergiaKlass Energiaklass { get; set; }

        public Hoone(string aadress, int pindala, Uks majaUks, EnergiaKlass energiaklass)
        {
            Aadress = aadress;
            Pindala = pindala;
            MajaUks = majaUks ?? throw new ArgumentNullException(nameof(majaUks));
            Energiaklass = energiaklass;
        }

        public virtual void InfoParing()
        {
            ParinguteArv++;

            if (MajaUks.OnLukus)
            {
                throw new UnauthorizedAccessException("Juurdepääs keelatud! Uks on lukus.");
            }

            Console.WriteLine($"Aadress: {Aadress}");
            Console.WriteLine($"Pindala: {Pindala} m²");
            Console.WriteLine($"Energiaklass: {Energiaklass}");
            Console.WriteLine($"Ülalpidamiskulu: {ArvutaYlalpidamiskulu()} eurot");
        }

        protected double RakendaEnergiaKordaja(double summa)
        {
            return Energiaklass switch
            {
                EnergiaKlass.A => summa * 0.8,
                EnergiaKlass.B => summa * 0.9,
                EnergiaKlass.C => summa,
                EnergiaKlass.D => summa * 1.2,
                _ => summa
            };
        }

        public abstract double ArvutaYlalpidamiskulu();
    }
}
