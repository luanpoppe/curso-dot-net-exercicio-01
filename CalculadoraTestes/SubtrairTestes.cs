using Calculadora;
using Xunit;

namespace CalculadoraTestes
{
  public class SubtrairTestes
  {
    [Theory]
    [InlineData("15", "7", "8")]
    [InlineData("100", "1", "99")]
    [InlineData("123", "23", "100")]
    [InlineData("50", "50", "0")]
    [InlineData("987654321", "123456789", "864197532")]
    [InlineData("1000", "999", "1")]
    public void TesteSubtracao(string n1, string n2, string expected)
    {
      var subtrair = new Subtrair();
      var resultado = subtrair.Execute(n1, n2);
      Assert.Equal(expected, resultado);
    }
  }
}
