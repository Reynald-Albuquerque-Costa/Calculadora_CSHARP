using System;

namespace Calculadora_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desligar = "0";

            Console.WriteLine("===== CALCULADORA =====");
            Console.WriteLine("Para iniciar digite '1': ");
            string ligar = Console.ReadLine();
            if (ligar == ("1"))
            {
                while (desligar != "1")
                {
                    Console.Write("Digite o primeiro numero: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o operador: ");
                    string operador = Console.ReadLine();

                    Console.Write("Digite o segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (operador)
                    {
                        case "+":
                            Console.WriteLine("Resultado: " + somar(num1, num2));
                            break;
                        case "-":
                            Console.WriteLine("Resultado: " + subtrair(num1, num2));
                            break;
                        case "*":
                            Console.WriteLine("Resultado: " + multiplicar(num1, num2));
                            break;
                        case "/":
                            Console.WriteLine("Resultado: " + dividir(num1, num2));
                            break;
                    }
                    Console.WriteLine("Para desligar digite aperte '1', para continuar digite '2'");
                    desligar = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Volte mais tarde");
            }

            Console.WriteLine("Obrigado por usar a nossa calculadora!");
        }

        public static string somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string dividir(int num1, int num2)
        {
            if (valorDividendoMenorOuIgualAZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }
            return (num1 / num2).ToString();

            bool valorDividendoMenorOuIgualAZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }

        }
    }
}
