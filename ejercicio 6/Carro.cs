using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_6
{
    class Carro
    {
        int _cantidadCombustible;

        public void Enceder()
        {
            if (_cantidadCombustible > 0)
            {
                _cantidadCombustible--;
                Console.WriteLine("el carro esta encendido");
            }
            else
            {
                Console.WriteLine("el carro no tiene combustible");
            }
        }

        public Carro(int _cantidadCombustible)
        {
            this._cantidadCombustible = _cantidadCombustible;
        }
    }
}
