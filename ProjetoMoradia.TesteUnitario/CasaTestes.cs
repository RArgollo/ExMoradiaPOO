using Xunit;
using ExMoradiaPOO;
namespace ProjetoMoradia.TesteUnitario
{
    public class CasaTestes
    {
        [Fact]
        public void CasaPodeTerAteTresBanheiros()
        {
            var quantidadeBanheiros = 6;
            var casa = new Casa("iguaçaba", "03379080", 80, quantidadeBanheiros, 2, true);
            var quantidadeBanheirosEsperada = casa.GetQuantidadeBanheiros();
            Assert.Equal(0, quantidadeBanheirosEsperada);
        }

        [Fact]
        public void CasaPodeTerAteCemMetros()
        {
            var tamanhoEmMetros = 200;
            var casa = new Casa("iguaçaba", "03379080", tamanhoEmMetros, 2, 2, true);
            var tamanhoEmMetrosEsperado = casa.GetTamanhoEmMetros();
            Assert.Equal(0, tamanhoEmMetrosEsperado);
        }

    }
}