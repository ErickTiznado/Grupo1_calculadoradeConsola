using System;

namespace Calculator
{
    class Grupo1_calculadoradeConsola
    { 
        static void Main(string[] args)
        {
            //Erick Mauricio Tiznado 
            //Franklin Stanley Larin
            //Oscar Manuel Lopez Velasquez
            //Nathaly Milena Zelaya Caballero 
            //Julissa Odaly Sosa Flores
            //Ana Carolina Guevara Rodriguez

            // Declara Variables y luego inicializa a cero.
            Double valor1 = 0; Double valor2 = 0;

            // Muestra el titulo como la aplicación de calculadora de la consola de C#
            Console.WriteLine("Calculadora de Consola en C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("A continuacion ingrese los valores a calcular\r");
            // Pedir al usuario que digite el primer número.
            Console.WriteLine("Digite un número y luego presione ENTER");
            valor1 = Convert.ToDouble(Console.ReadLine());

            // Pedir al usaurio que digite el segundo número.
            Console.WriteLine("Digite otro número y luego presione ENTER");
            valor2 = Convert.ToDouble(Console.ReadLine());

            // Pedir al usuario que seleccione una opción
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\tS - Sumar");
            Console.WriteLine("\tR - Restar");
            Console.WriteLine("\tM - Multiplicar");
            Console.WriteLine("\tD - Dividir");
            Console.Write("¿Que obcion piensa elejir? ");

            // Usa una sentencia de cambio para hacer los cálculos.
            switch (Console.ReadLine())
            {
                case "S":
                    Console.WriteLine($"El resultado es: {valor1} + {valor2 } = " + (valor1 + valor2));
                    break;
                case "R":
                    Console.WriteLine($"El resultado es: {valor1} - {valor2} = " + (valor1 - valor2));
                    break;
                case "M":
                    Console.WriteLine($"El resultado es: {valor1} * {valor2} = " + (valor1 * valor2));
                    break;
                case "D":
                    Console.WriteLine($"El resultado es: {valor1} / {valor2} = " + (valor1 / valor2));
                    break;
            }
            // Espere a que el usuario responda antes de cerrar.
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la Calculadora de Consola");
            Console.ReadKey();
        }
    }
}
