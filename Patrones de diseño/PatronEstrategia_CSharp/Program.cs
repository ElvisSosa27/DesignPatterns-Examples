using System;
using PatronEstrategia_CSharp.Estrategias;

namespace PatronEstrategia_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanDeViaje plan = new PlanDeViaje();

            plan.Estrategia(new Avion());
            plan.Manejar(1100);

            Console.ReadKey();
        }
    }
}
