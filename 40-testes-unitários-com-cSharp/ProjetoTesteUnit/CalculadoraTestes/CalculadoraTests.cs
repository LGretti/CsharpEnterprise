using System.Reflection.Metadata;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes() //construtor
    {
        _calc = new CalculadoraImp();
    }

    [Fact]//indica que é um método de testes
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int n1 = 5;
        int n2 = 10;
        
        //Act
        int r = _calc.Somar(n1, n2);

        //Assert
        Assert.Equal(15, r);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        //Arrange
        int n = 4;

        //Act
        bool r = _calc.EhPar(n);

        //Assert
        Assert.True(r);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoVerdadeirosERetornarTrue(int numero){
        //arrange
        //act
        bool r = _calc.EhPar(numero);

        //assert
        Assert.True(r);
    }
}