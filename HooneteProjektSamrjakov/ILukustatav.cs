using System;
using System.Collections.Generic;
using System.Text;

namespace HooneteProjektSamrjakov
{
    public interface ILukustatav
    {
        bool OnLukus { get; }
        public void Lukusta();
        public void Ava();
    }
}
