using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona persona = new Persona();

            persona.Nombre = "Maria";
            persona.Apellido = "Sosa";
            persona.Edad = 25;
            persona.Salario = 12312.313;

            persona.ImprimirDatos();

            Console.WriteLine("------------------------------");

            Persona persona2 = new Persona();
            persona2.Nombre = "Jorge";
            persona2.Apellido = "Peña";
            persona2.Edad = 30;
            persona2.Salario = 5896;

            persona2.ImprimirDatos();

            Console.WriteLine("------------------------------");

            Persona persona3 = new Persona();
            persona3.Nombre = "David";
            persona3.Apellido = "Cortez";
            persona3.Edad = 32;
            persona3.Salario = 3574159;

            persona3.ImprimirDatos();

            Console.WriteLine("------------------------------");

        }
    }
}
