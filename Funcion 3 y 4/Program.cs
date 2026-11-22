using System;

class Program
{
    static double AreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    static string MensajeEdad(int edad)
    {
        if (edad >= 18)
        {
            return "Tienes " + edad + " años, eres mayor de edad";
        }
        return "Tienes " + edad + " años, eres menor de edad";
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

    static int PedirEdad()
    {
        int edad;
        Console.Write("Edad: ");
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0 || edad > 120)
        {
            Console.Write("Edad no valida, escribe un numero entre 0 y 120: ");
        }
        return edad;
    }

    static void Main()
    {
        string op;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Area del circulo");
            Console.WriteLine("2. Verificar edad");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            op = Console.ReadLine();

            if (op == "1")
            {
                double r = PedirNumero("Radio: ");
                Console.WriteLine("Area del circulo = " + AreaCirculo(r).ToString("F2"));
            }
            else if (op == "2")
            {
                int edad = PedirEdad();
                Console.WriteLine(MensajeEdad(edad));
            }
            else if (op != "0")
            {
                Console.WriteLine("Opcion invalida");
            }
        } while (op != "0");
    }
}
