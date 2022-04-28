using Xunit;
using ExMoradiaPOO;
namespace ProjetoMoradia.TesteUnitario
{
    public class MoradiaTestes
    {
        [Fact]
        public void CEPDeveConterSomenteOitoDigitos()
        {
            var cep = "033790800";
            var moradia = new Moradia("iguaçaba", cep, 100, 2, 3);
            var cepEsperado = moradia.GetCEP();
            Assert.Equal("", cepEsperado);
        }
    }
}