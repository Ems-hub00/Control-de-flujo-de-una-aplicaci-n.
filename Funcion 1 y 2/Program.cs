
using System;

class Program
{
    static double AreaTriangulo(double b, double h)
    {
        return b * h / 2;
    }

    static double AreaCuadrado(double lado)
    {
        return lado * lado;
    }

    static double PedirNumero(string texto)
    {
        double n;
        Console.Write(texto);
        while (!double.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Valor no valido, escribe un numero mayor que 0: ");
        }
        return n;
    }

    static void Main()
    {
        string op;
        do
        {
            Console.WriteLine("\n===== CALCULADORA DE AREAS =====");
            Console.WriteLine("1. Area del triangulo");
            Console.WriteLine("2. Area del cuadrado");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            op = Console.ReadLine();

            if (op == "1")
            {
                double b = PedirNumero("Base: ");
                double h = PedirNumero("Altura: ");
                Console.WriteLine("Area del triangulo = " + AreaTriangulo(b, h));
            }
            else if (op == "2")
            {
                double l = PedirNumero("Lado: ");
                Console.WriteLine("Area del cuadrado = " + AreaCuadrado(l));
            }
            else if (op != "0")
            {
                Console.WriteLine("Opcion invalida");
            }
        } while (op != "0");
    }
}