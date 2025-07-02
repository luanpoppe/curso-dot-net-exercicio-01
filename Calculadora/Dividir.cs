using System;
using System.Text;

namespace Calculadora
{
  public class Dividir : OperacaoMatematica
  {
    public override string Execute(string dividendo, string divisor)
    {
      if (divisor == "0") throw new DivideByZeroException();
      if (dividendo == "0") return "0";
      if (IsLesser(dividendo, divisor)) return "0";

      StringBuilder quociente = new StringBuilder();
      StringBuilder dividendoParcial = new StringBuilder();

      for (int i = 0; i < dividendo.Length; i++)
      {
        dividendoParcial.Append(dividendo[i]);

        RemoveLeadingZero(dividendoParcial);

        if (IsLesser(dividendoParcial.ToString(), divisor))
        {
          quociente.Append('0');
          continue;
        }

        int contador = 0;
        while (IsGreaterOrEqual(dividendoParcial.ToString(), divisor))
        {
          dividendoParcial = new StringBuilder(new Subtrair().Execute(dividendoParcial.ToString(), divisor));
          contador++;
        }
        quociente.Append(contador);
      }

      return quociente.ToString().TrimStart('0');
    }

    private bool IsGreaterOrEqual(string numero1, string numero2)
    {
      if (numero1.Length > numero2.Length) return true;
      if (numero1.Length < numero2.Length) return false;
      return string.Compare(numero1, numero2) >= 0;
    }

    private bool IsLesser(string numero1, string numero2)
    {
      if (numero1.Length < numero2.Length) return true;
      if (numero1.Length > numero2.Length) return false;
      return string.Compare(numero1, numero2) < 0;
    }
    private void RemoveLeadingZero(StringBuilder dividendoParcial)
    {
      while (dividendoParcial.Length > 1 && dividendoParcial[0] == '0')
      {
        dividendoParcial.Remove(0, 1);
      }
    }
  }

}
