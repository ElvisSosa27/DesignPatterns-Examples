using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia_CSharp.Estrategias
{
    public class Automovil : Viajar
    {
        public Automovil()
        {
            CostoPorKilometro = 10;
        }

        public override decimal Manejar(int kilometros)
        {
            return kilometros * CostoPorKilometro;
        }
    }
}
