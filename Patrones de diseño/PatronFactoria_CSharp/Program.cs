using System;
using PatronFactoria_CSharp.Continentes;

namespace PatronFactoria_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Continente[] continentes = new Continente[2];

            continentes[0] = new America();
            continentes[1] = new Europa();

            foreach(Continente continente in continentes)
            {
                Console.WriteLine(continente.GetType().Name + ":");
                foreach(Animal animal in continente.animales)
                {
                    Console.WriteLine(" " + animal.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
