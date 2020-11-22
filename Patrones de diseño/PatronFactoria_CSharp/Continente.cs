using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoria_CSharp
{
    abstract class Continente
    {
        private List<Animal> anml = new List<Animal>();

        protected Continente()
        {
            Continente_Crear();
        }

        public List<Animal> animales => anml;

        public abstract void Continente_Crear();
    }
}
