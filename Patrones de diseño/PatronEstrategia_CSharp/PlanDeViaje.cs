using System;
using System.Collections.Generic;
using System.Text;

namespace PatronEstrategia_CSharp
{
    public class PlanDeViaje
    {
        private Viajar viaje;

        public void Estrategia(Viajar Viaje)
        {
            viaje = Viaje;
        }

        public void Manejar(int kilometros)
        {
            var costo = viaje.Manejar(kilometros);
            Console.WriteLine("Costo del viaje: " + costo);
        }
    }
}
