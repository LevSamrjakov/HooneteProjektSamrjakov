using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    class StartPage
    {
        static void Main()
        {
            Uks eramajaUks = new Uks("Punane");
            Uks kortermajaUks = new Uks("Valge");

            EraMaja eramaja = new EraMaja(
                "Vatslanurme 25",
                100,
                eramajaUks,
                true,
                EnergiaKlass.A);

            KorteriteMaja kortermaja = new KorteriteMaja(
                "Kopliranna 27",
                900,
                kortermajaUks,
                3,
                EnergiaKlass.C);

            try
            {
                kortermaja.LisaElanik(new Inimene("Lev"));
                kortermaja.LisaElanik(new Inimene("Maksim"));
                kortermaja.LisaElanik(new Inimene("Ljudmilla"));


                kortermaja.LisaElanik(new Inimene("Nikolaj"));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Hoone> hooned = new List<Hoone>
        {
            eramaja,
            kortermaja
        };

            foreach (Hoone hoone in hooned)
            {
                int katsed = 0;
                bool onnistus = false;

                while (katsed < 3 && !onnistus)
                {
                    try
                    {
                        hoone.InfoParing();
                        onnistus = true;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine(ex.Message);

                        Console.Write("Sisesta parool: ");
                        string parool = Console.ReadLine();

                        if (parool == "1325")
                        {
                            hoone.MajaUks.Ava();
                        }
                        else
                        {
                            Console.WriteLine("Vale parool.");
                        }

                        katsed++;
                    }
                }

                if (!onnistus)
                {
                    Console.WriteLine("Süsteem lukustati pärast 3 ebaõnnestunud katset.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Päringuid kokku: {Hoone.ParinguteArv}");

            //Saving
        }
    }
}
