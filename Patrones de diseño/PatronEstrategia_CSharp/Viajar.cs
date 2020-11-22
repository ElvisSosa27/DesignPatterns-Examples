using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia_CSharp
{
    public abstract class Viajar
    {
        public int CostoPorKilometro;
        public abstract decimal Manejar(int kilometros);
    }
}
