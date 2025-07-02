using System.Text;

namespace Calculadora
{
    public class Subtrair : OperacaoMatematica
    {
        public override string Execute(string numero1, string numero2)
        {
            if (numero1 == numero2) return "0";

            StringBuilder stringBuilder = new StringBuilder();
            int pegaUm = 0;
            int tamanho1 = numero1.Length - 1;
            int tamanho2 = numero2.Length - 1;

            while (tamanho1 >= 0)
            {
                int digito1 = numero1[tamanho1--] - '0';
                int digito2 = tamanho2 >= 0 ? numero2[tamanho2--] - '0' : 0;

                int sub = digito1 - digito2 - pegaUm;
                if (sub < 0)
                {
                    sub += 10;
                    pegaUm = 1;
                }
                else
                {
                    pegaUm = 0;
                }
                stringBuilder.Insert(0, sub);
            }

            // Remove leading zeros
            string resultado = stringBuilder.ToString().TrimStart('0');
            return retornaResultadoFinal(resultado);
        }

        private string retornaResultadoFinal(string resultado)
        {
            return string.IsNullOrEmpty(resultado) ? "0" : resultado;
        }
    }
}
