using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3
{
    static class Aritmetica
    {
        // Sumar
        static void Sumar(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Sumar(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        static void Sumar(int a, int b, int c, int d)
        {
            Console.WriteLine(a + b + c + d);
        }
        // Restar
        static void Restar(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Restar(int a, int b, int c)
        {
            Console.WriteLine(a - b - c);
        }
        static void Restar(int a, int b, int c, int d)
        {
            Console.WriteLine(a - b - c - d);
        }
        
        // Multiplicar
        static void Multiplicar(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        // Dividir
        static void Dividir(int a, int b)
        {
            Console.WriteLine(a / b);
        }



        static void Main(string[] args)
        {
            Aritmetica.Restar(50, 5, 16);
            Console.ReadKey();
        }

    }
}
