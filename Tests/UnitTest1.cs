using Xunit;

namespace Tests;

public class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }
}

public class UnitTest1
{
    [Fact]
    public void Sumar_DosNumeros_RetornaResultadoCorrecto()
    {
        var calc = new Calculadora();
        var resultado = calc.Sumar(2, 3);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Sumar_NumerosNegativos_FuncionaCorrectamente()
    {
        var calc = new Calculadora();
        var resultado = calc.Sumar(-2, -3);

        Assert.Equal(-5, resultado);
    }
}