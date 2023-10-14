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
}