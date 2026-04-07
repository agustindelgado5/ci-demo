using Xunit;
using ci_demo;
namespace Tests;



// Tests unitarios para cada operación
public class UnitTest1
{
    [Fact]
    public void Sumar_DosNumeros_RetornaResultadoCorrecto()
    {
        var calc = new Calculadora();
        Assert.Equal(5, calc.Sumar(2, 3));
    }

    [Fact]
    public void Sumar_NumerosNegativos_RetornaResultadoCorrecto()
    {
        var calc = new Calculadora();
        Assert.Equal(-5, calc.Sumar(-2, -3));
    }

    [Fact]
    public void Restar_DosNumeros_RetornaResultadoCorrecto()
    {
        var calc = new Calculadora();
        Assert.Equal(2, calc.Restar(5, 3));
    }

    [Fact]
    public void Restar_NumerosNegativos_RetornaResultadoCorrecto()
    {
        var calc = new Calculadora();
        Assert.Equal(-1, calc.Restar(-4, -3));
    }

    [Fact]
    public void Multiplicar_DosNumeros_RetornaResultadoCorrecto()
    {
        var calc = new Calculadora();
        Assert.Equal(6, calc.Multiplicar(2, 3));
    }

    [Fact]
    public void Multiplicar_NumeroPorCero_RetornaCero()
    {
        var calc = new Calculadora();
        Assert.Equal(0, calc.Multiplicar(5, 0));
    }

    [Fact]
    public void Dividir_DosNumeros_RetornaResultadoCorrecto()
    {
        var calc = new Calculadora();
        Assert.Equal(2, calc.Dividir(6, 3));
    }

    [Fact]
    public void Dividir_EntreCero_LanzaExcepcion()
    {
        var calc = new Calculadora();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(5, 0));
    }
}