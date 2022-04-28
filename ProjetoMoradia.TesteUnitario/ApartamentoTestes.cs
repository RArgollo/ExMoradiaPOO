using Xunit;
using ExMoradiaPOO;
namespace ProjetoMoradia.TesteUnitario
{
    public class ApartamentoTestes
    {
        [Fact]
        public void ApartamentoPodeTerAteTresBanheiros()
        {
            var quantidadeBanheiros = 4;
            var apartamento = new Apartamento("iguaçaba", "03379080", 60, quantidadeBanheiros, 2, 10, 700);
            var quantidadeBanheirosEsperada = apartamento.GetQuantidadeBanheiros();
            Assert.Equal(0, quantidadeBanheirosEsperada);
        }

        [Fact]
        public void ApartamentoPodeTerAteSessentaMetros()
        {
            var tamanhoEmMetros = 70;
            var apartamento = new Apartamento("iguaçaba", "03379080", tamanhoEmMetros, 3, 2, 10, 700);
            var tamanhoEmMetrosEsperado = apartamento.GetTamanhoEmMetros();
            Assert.Equal(0, tamanhoEmMetrosEsperado);
        }

        [Fact]
        public void ApartamentoPodeSerAteDecimoAndar()
        {
            var andar = 11;
            var apartamento = new Apartamento("iguaçaba", "03379080", 60, 3, 2, andar, 700);
            var andarEsperado = apartamento.GetAndar();
            Assert.Equal(0, andarEsperado);
        }
    }
}