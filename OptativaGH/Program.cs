using System;

namespace OptativaGH
{
    class Program
    {
        static void Main(string[] args)
        {   //The user is welcomed
            Console.WriteLine("Este es un programa de prueba");

            //Declaring implicit variables
            var a = 0;
            var b = 0;
            var c = 0;
            
            //Instructions for the user
            Console.WriteLine("Ingrese dos numeros:");
            
            //Converting text string to integer
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            //The sum of the numbers is performed
            c = a + b;
            
            //The result is displayed
            Console.WriteLine($"La suma de los numeros es: {c}.");
            Console.WriteLine("La suma se ha realizado correctamente. Tenga un feliz dia");
        }
    }
}
