using System;
using System.Collections.Generic;
using System.Text;

namespace PatronInstanciaUnica_Ejemplo
{
    public class Calculadora
    {
        private readonly Registrar registrar;
        public Calculadora()
        {
            registrar = Registrar.GetRegistrar();
        }

        public void Dividir(int a, int b)
        {
            try
            {
                var resultado = a / b;
                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                registrar.registro(ex.Message);
            }
        }
    }
}
