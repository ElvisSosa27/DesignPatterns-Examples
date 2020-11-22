using System;
using System.Collections.Generic;
using System.Text;
using PatronFactoria_CSharp.Animales;

namespace PatronFactoria_CSharp.Continentes
{
    class America : Continente
    {
        public override void Continente_Crear()
        {
            animales.Add(new Arana());
            animales.Add(new Raton());
        }
    }
}
