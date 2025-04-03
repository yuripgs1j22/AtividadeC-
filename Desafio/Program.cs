using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("Resultado: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Divisão por zero não é válida.");
                }
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
