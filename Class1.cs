using System;

class Calculadora
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione la operación que desea realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case "1":
                    
                case "2":
                   
                case "3":
                    
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado de la división: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

            Console.Write("¿Desea continuar? (S/N): ");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "N")
            {
                continuar = false;
                Console.WriteLine("Programa finalizado.");
            }
        }
    }
}
