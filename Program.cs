using System;

namespace T04Ejercicio23
{
    class CalculadoraInversa
    {
        static void Main()
        {
            Console.WriteLine("Escriba el primer operando (A): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo operando (B): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el signo aritmético (+,-,*,/,^,%): ");
            String signo = Console.ReadLine();

            switch (signo)
            {
                case "+":
                    Console.WriteLine("El resultado de A+B es: " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("El resultado de A-B es: " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("El resultado de A*B es: " + (a * b));
                    break;
                case "/":
                    double aDoble = Convert.ToDouble(a);
                    double bDoble = Convert.ToDouble(b);
                    Console.WriteLine("El resultado de A/B es: " + (aDoble / bDoble));
                    break;
                case "^":
                    Console.WriteLine("El resultado de A^B es: " + Math.Pow(a, b));
                    break;
                case "%":
                    Console.WriteLine("El resultado de A%B es: " + (a % b));
                    break;
                default:
                    Console.WriteLine("No ha escrito el signo correctamente.");
                    break;
            }
        }
    }
}