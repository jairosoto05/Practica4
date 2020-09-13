using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante juan = new Estudiante(69, 97, 93, 90);

            Console.WriteLine(juan.promedio);

            Console.ReadKey();
        }
        
    }
}
