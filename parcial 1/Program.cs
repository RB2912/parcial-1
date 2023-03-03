// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número entero positivo N mayor que cero
        Console.Write("Ingrese un número entero positivo N mayor que cero: ");
        int N = int.Parse(Console.ReadLine());

        // Calcular el factorial de N y almacenar el resultado en la variable factorial
        int factorial = 1;
        for (int i = 1; i <= N; i++)
        {
            factorial *= i;
        }

        // Imprimir los números enteros positivos menores o iguales que N que sean divisibles entre 3
        Console.Write("Los números enteros positivos menores o iguales que N que son divisibles entre 3 son: ");
        for (int i = 1; i <= N; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();

        // Imprimir los números enteros positivos menores o iguales que N que sean divisibles entre 5
        Console.Write("Los números enteros positivos menores o iguales que N que son divisibles entre 5 son: ");
        for (int i = 1; i <= N; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();

        // Imprimir la secuencia de números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que N
        Console.Write("La secuencia de números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que N es: ");
        for (int i = 1; i <= N; i += 2)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();

        // Imprimir el valor de factorial
        Console.WriteLine("El factorial de {0} es {1}.", N, factorial);

        Console.ReadLine();
    }
}
