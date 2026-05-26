using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public class Uks : ILukustatav
    {
        private bool _onLukus = true;

        public string Varv { get; set; }

        public bool OnLukus => _onLukus;

        public Uks(string varv)
        {
            Varv = varv;
        }

        public void Lukusta()
        {
            _onLukus = true;
            Console.WriteLine("Uks on lukustatud.");
        }

        public void Ava()
        {
            _onLukus = false;
            Console.WriteLine("Uks on avatud.");
        }
    }
}
