using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia_CSharp.Estrategias
{
    public class Avion : Viajar
    {
        public Avion()
        {
            CostoPorKilometro = 50;
        }

        public override decimal Manejar(int kilometros)
        {
            if (kilometros > 1000)
            {
                CostoPorKilometro = 120;
            }
            return kilometros * CostoPorKilometro;
        }
    }
}
