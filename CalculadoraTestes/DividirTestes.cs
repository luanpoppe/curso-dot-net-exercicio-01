using Calculadora;
using Xunit;
using System.Numerics;

namespace CalculadoraTestes
{
  public class DividirTestes
  {
    [Theory]
    [InlineData("10", "3", "3")]
    [InlineData("9", "3", "3")]
    [InlineData("100", "10", "10")]
    [InlineData("12345", "1", "12345")]
    [InlineData("123456789", "123", "1003713")]
    [InlineData("864197532", "9876", "87504")]
    public void TesteDivisao(string n1, string n2, string expected)
    {
      var dividir = new Dividir();
      var resultado = dividir.Execute(n1, n2);
      Assert.Equal(expected, resultado);
    }
  }
}
