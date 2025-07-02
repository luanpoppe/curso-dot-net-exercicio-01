using System;
using System.IO;

namespace Calculadora
{
    public class Program
    {
        public static void Main()
        {
            string numero1 = File.ReadAllText("numero1.txt");
            string numero2 = File.ReadAllText("numero2.txt");

            Console.WriteLine("Escolha a operacao:");
            Console.WriteLine("1. Adicao");
            Console.WriteLine("2. Subtracao");
            Console.WriteLine("3. Multiplicacao");
            Console.WriteLine("4. Divisao");

            string? escolha = Console.ReadLine();
            OperacaoMatematica? operacao;
            string resultado;

            switch (escolha)
            {
                case "1":
                    operacao = new Somar();
                    resultado = operacao.Execute(numero1, numero2);
                    break;
                case "2":
                    operacao = new Subtrair();
                    resultado = operacao.Execute(numero1, numero2);
                    break;
                case "3":
                    operacao = new Multiplicar();
                    resultado = operacao.Execute(numero1, numero2);
                    break;
                case "4":
                    operacao = new Dividir();
                    resultado = operacao.Execute(numero1, numero2);
                    break;
                default:
                    Console.WriteLine("Escolha invalida.");
                    return;
            }

            File.WriteAllText("resultado.txt", resultado);
            Console.WriteLine("Resultado salvo no arquivo resultado.txt");
        }
    }
}
