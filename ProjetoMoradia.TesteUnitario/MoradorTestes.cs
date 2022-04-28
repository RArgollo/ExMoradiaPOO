using Xunit;
using ExMoradiaPOO;

namespace ProjetoMoradia.TesteUnitario;

public class MoradorTestes
{
    [Fact]
    public void NomeMoradorDeveSerIgualAoEsperado()
    {
        var nomeEsperado = "Rafael";
        var morador = new Morador(nomeEsperado, "11122233345", "19/11/2001");
        var nome = morador.GetNome();
        Assert.Equal(nomeEsperado, nome);
    }

    [Fact]
    public void CPFMoradorDeveSerIgualAoEsperado()
    {
        var cpfEsperado = "11122233345";
        var morador = new Morador("Rafael", cpfEsperado, "19/11/2001");
        var cpf = morador.GetCPF();
        Assert.Equal(cpfEsperado, cpf);
    }

    [Fact]
    public void DataNascimentoMoradorDeveSerIgualAEsperada()
    {
        var dataNascimentoEsperada = "19/11/2001";
        var morador = new Morador("Rafael", "11122233345", dataNascimentoEsperada);
        var dataNascimento = morador.GetDataNascimento();
        Assert.Equal(dataNascimentoEsperada, dataNascimento.ToString("dd/MM/yyyy"));
    }

    [Fact]
    public void CPFMoradorNaoDeveSalvarQuandoInvalido()
    {
        var cpfInvalido = "11122233344456";
        var morador = new Morador("Rafael", cpfInvalido, "19/11/2001");
        var cpf = morador.GetCPF();
        Assert.Equal("", cpf);
    }
}