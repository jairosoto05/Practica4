using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    class Estudiante
    {
        int nota1;
        int nota2;
        int nota3;
        int nota4;
        public double promedio;

        public Estudiante(int nota1, int nota2, int nota3, int nota4)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.promedio = (nota1 + nota2 + nota3 + nota4) / 4;
        }

    }

}
