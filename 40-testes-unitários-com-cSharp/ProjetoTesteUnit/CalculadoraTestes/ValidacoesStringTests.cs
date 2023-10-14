using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoesString;

        public ValidacoesStringTests() //construtor
        {
            _validacoesString = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string t = "Olá";

            //Act
            int r = _validacoesString.ContarCaracteres(t);

            //Assert
            Assert.Equal(3, r);
        }
    }
}