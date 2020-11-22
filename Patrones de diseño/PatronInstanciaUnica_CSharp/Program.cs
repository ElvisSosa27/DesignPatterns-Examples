using System;

namespace PatronInstanciaUnica_Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Dividir(2, 0);

            Console.ReadKey();
        }
    }
}
