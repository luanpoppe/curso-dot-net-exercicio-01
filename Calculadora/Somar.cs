using System.Text;

namespace Calculadora
{
    public class Somar : OperacaoMatematica
    {
        public override string Execute(string numero1, string numero2)
        {
            if (numero1 == "0" && numero2 == "0") return "0";

            StringBuilder stringBuilder = new StringBuilder();
            int sobra = 0;
            int tamanho1 = numero1.Length - 1;
            int tamanho2 = numero2.Length - 1;

            while (tamanho1 >= 0 || tamanho2 >= 0 || sobra > 0)
            {
                int digito1 = tamanho1 >= 0 ? numero1[tamanho1--] - '0' : 0;
                int digito2 = tamanho2 >= 0 ? numero2[tamanho2--] - '0' : 0;
                int soma = digito1 + digito2 + sobra;
                sobra = soma / 10;
                stringBuilder.Insert(0, soma % 10);
            }

            return stringBuilder.ToString();
        }
    }
}
