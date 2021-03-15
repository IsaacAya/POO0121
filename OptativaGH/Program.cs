using System;

namespace OptativaGH
{
    class Program
    {
        static void Main(string[] args)
        {   var a = 0;
            var b = 0;
            var c = 0;
            Console.WriteLine("Ingrese dos numeros:");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine($"La suma de los numeros es: {c}.");
        }
    }
}
