namespace ExMoradiaPOO
{
    public class Kitnet : Moradia
    {
        public Kitnet(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            Endereco = endereco;
            CEP = cep;
            TamanhoEmMetros = tamanhoEmMetros;
            QuantidadeBanheiros = quantidadeDeBanheiros;
            QuantidadeQuartos = quantidadeDeQuartos;
        }

        public override void CalcularValorAluguel()
        {
            var valorAluguel = TamanhoEmMetros * 30;
            Console.WriteLine($"O valor do aluguel da kitnet é de R${valorAluguel}");
        }
    }
}