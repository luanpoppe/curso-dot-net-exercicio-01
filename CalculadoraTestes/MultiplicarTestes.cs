using Calculadora;
using Xunit;

namespace CalculadoraTestes
{
  public class MultiplicarTestes
  {
    [Theory]
    [InlineData("8", "9", "72")]
    [InlineData("123", "45", "5535")]
    [InlineData("99", "0", "0")]
    [InlineData("0", "99", "0")]
    [InlineData("100", "100", "10000")]
    [InlineData("123456789", "987654321", "121932631112635269")]
    public void TesteMultiplicacao(string n1, string n2, string expected)
    {
      var multiplicar = new Multiplicar();
      var resultado = multiplicar.Execute(n1, n2);
      Assert.Equal(expected, resultado);
    }
  }
}
