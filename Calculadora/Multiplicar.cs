using System;
using System.Text;
using System.Linq;

namespace Calculadora
{
    public class Multiplicar : OperacaoMatematica
    {
        public override string Execute(string rawNumero1, string rawNumero2)
        {
            if (IsAlgumDosNumerosZero(rawNumero1, rawNumero2)) return "0";


            var numero1 = ReverterNumero(rawNumero1);
            var numero2 = ReverterNumero(rawNumero2);

            int[] resultado = new int[numero1.Length + numero2.Length];

            for (int i = 0; i < numero1.Length; i++)
            {
                int digito1 = numero1[i] - '0';
                int sobra = 0;

                for (int j = 0; j < numero2.Length; j++)
                {
                    int digito2 = numero2[j] - '0';
                    int produto = digito1 * digito2 + resultado[i + j] + sobra;
                    sobra = produto / 10;
                    resultado[i + j] = produto % 10;
                }

                if (sobra > 0)
                {
                    resultado[i + numero2.Length] += sobra;
                }
            }

            StringBuilder stringBuilder = AdicionarNumerosDaEsquerdaParaDireita(resultado);

            return stringBuilder.Length == 0 ? "0" : stringBuilder.ToString();
        }
        private string ReverterNumero(string numero1)
        {
            return new string(numero1.ToCharArray().Reverse().ToArray());
        }

        private bool IsAlgumDosNumerosZero(string numero1, string numero2)
        {
            return numero1 == "0" || numero2 == "0";
        }

        private StringBuilder AdicionarNumerosDaEsquerdaParaDireita(int[] resultado)
        {
            StringBuilder stringBuilder = new StringBuilder();
            // Append digits from left to right (reverse of how they were calculated)
            int i = resultado.Length - 1;
            while (i >= 0 && resultado[i] == 0)
            {
                i--;
            }

            if (i == -1)
            {
                return new StringBuilder("0");
            }

            while (i >= 0)
            {
                stringBuilder.Append(resultado[i]);
                i--;
            }

            return stringBuilder;
        }
    }

}
