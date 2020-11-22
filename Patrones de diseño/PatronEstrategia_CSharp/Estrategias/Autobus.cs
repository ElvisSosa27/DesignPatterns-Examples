using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia_CSharp.Estrategias
{
    public class Autobus : Viajar
    {
        public Autobus()
        {
            CostoPorKilometro = 15;
        }

        public override decimal Manejar(int kilometros)
        {
            return kilometros * CostoPorKilometro;
        }
    }
}
