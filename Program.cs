using System;

class Program
{
    static void Main()
    {
        // Pedir ao usuário para digitar um número
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verificar se o número é positivo, negativo ou zero
        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }
    }
}