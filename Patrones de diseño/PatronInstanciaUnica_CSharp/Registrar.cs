using System;
using System.Collections.Generic;
using System.Text;

namespace PatronInstanciaUnica_Ejemplo
{
    sealed class Registrar
    {
        private static readonly Registrar registrar = new Registrar();

        public static Registrar GetRegistrar()
        {
            return registrar;
        }

        public void registro(string message)
        {
            Console.WriteLine("Error: " + message);
        }
    }
}
