using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public abstract class Hoone
    {
        public string Aadress { get; set; }
        public int Pindala { get; set; }
        public Uks MajaUks { get; set; }

        public Hoone(string aadress, int pindala, Uks majaUks)
        {
            Aadress = aadress;
            Pindala = pindala;
            MajaUks = majaUks;
        }

        public void InfoParing()
        {
            if(MajaUks.OnLukus)
            {
                throw new UnauthorizedAccessException("Juurdepääs keelatud! Uks on lukus.");
            }
            else
            {
                Console.WriteLine($"Aadress on: {Aadress}");
                Console.WriteLine($"Pindala on: {Pindala}");
                Console.WriteLine($"Ülalpidamiskulu on: {Ülalpidamiskulu()} €");
            }
        }

        public abstract double Ülalpidamiskulu();
    }
}
