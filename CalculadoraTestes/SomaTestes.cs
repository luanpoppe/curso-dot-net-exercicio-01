using Calculadora;
using Xunit;

namespace CalculadoraTestes
{
  public class SomaTestes
  {
    [Theory]
    [InlineData("5", "7", "12")]
    [InlineData("99", "1", "100")]
    [InlineData("123", "456", "579")]
    [InlineData("999", "1", "1000")]
    [InlineData("1", "999", "1000")]
    [InlineData("123456789", "987654321", "1111111110")]
    public void TesteSoma(string n1, string n2, string expected)
    {
      var somar = new Somar();
      var resultado = somar.Execute(n1, n2);
      Assert.Equal(expected, resultado);
    }
  }
}
