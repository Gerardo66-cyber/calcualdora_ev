using System;

class Program
{
    static void Main()
    {
        string respuesta;

        do
        {
            Console.WriteLine("Elije una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            Console.Write("Ingresa el número de la operación: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.Write("¿Deseas seguir? (si/no): ");
            respuesta = Console.ReadLine().ToLower();
        } while (respuesta == "si");
    }
}

    
