using Xunit;
using LojaVirtual.Core;

namespace LojaVirtual.Tests
{
    public class DescontoServiceTests
    {
        [Fact]
        public void DeveAplicarDescontoDe10PorCentoParaClienteVIP()
        {
            // Arrange
            var descontoService = new DescontoService();
            var valorCompra = 100m;

            // Act
            var valorComDesconto = descontoService.AplicarDesconto(valorCompra, true);

            // Assert
            Assert.Equal(90, valorComDesconto);
        }
    }
}
