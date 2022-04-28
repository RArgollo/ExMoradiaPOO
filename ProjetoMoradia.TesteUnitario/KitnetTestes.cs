using Xunit;
using ExMoradiaPOO;
namespace ProjetoMoradia.TesteUnitario
{
    public class KitnetTestes
    {
        [Fact]
        public void KitnetPodeTerAteDoisBanheiros()
        {
            var quantidadeBanheiros = 3;
            var kitnet = new Kitnet("iguaçaba", "03379080", 50, quantidadeBanheiros, 2);
            var quantidadeBanheirosEsperada = kitnet.GetQuantidadeBanheiros();
            Assert.Equal(0, quantidadeBanheirosEsperada);
        }

        [Fact]
        public void KitnetPodeTerAteCinquentaMetros()
        {
            var tamanhoEmMetros = 70;
            var kitnet = new Kitnet("iguaçaba", "03379080", tamanhoEmMetros, 2, 2);
            var tamanhoEmMetrosEsperado = kitnet.GetTamanhoEmMetros();
            Assert.Equal(0, tamanhoEmMetrosEsperado);
        }

    }
}