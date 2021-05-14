using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo a calculadora C#\n\n");
            string option;
            double number1, number2;
          
            while(true)
            {
                Console.WriteLine("*********  Menu  *********\n");
                Console.WriteLine("+   ;   -   ;   *   ;  /  ;  s => SAIR");
                option = Console.ReadLine();
     
                if (option == "s")
                {
                    Console.WriteLine("Saindo!");
                    break;
                }

                number1 = ReadInput(1);
                number2 = ReadInput(2);

                switch (option)
                {
                    case "+":
                        Sum(number1, number2);
                        break;
                    case "-":
                        Subtract(number1, number2);
                        break;
                    case "*":
                        Multiple(number1, number2);
                        break;
                    case "/":
                        Division(number1, number2);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            }
            
        }
        
       static double ReadInput(int value)
        {
            Console.WriteLine($"Informe o valor do número {value}");
            double input = double.Parse(Console.ReadLine());
            return input;
        }

        static void Sum(double number1, double number2)
        {
            double total = number1 + number2;
            Console.WriteLine($"Total: {total}");
        }

        static void Subtract(double number1, double number2)
        {
            double total = number1 - number2;
            Console.WriteLine($"Total: {total}");
        }

        static void Multiple(double number1, double number2)
        {
            double total = number1 * number2;
            Console.WriteLine($"Total: {total}");
        }

        static void Division(double number1, double number2)
        {
            double total = number1 / number2;
            Console.WriteLine($"Total: {total}");
        }
    }
}
