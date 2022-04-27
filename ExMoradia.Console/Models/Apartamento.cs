namespace ExMoradiaPOO
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }

        public Apartamento(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos, int andar, double valorCondominio) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            Endereco = endereco;
            CEP = cep;
            TamanhoEmMetros = tamanhoEmMetros;
            QuantidadeBanheiros = quantidadeDeBanheiros;
            QuantidadeQuartos = quantidadeDeQuartos;
            Andar = andar;
            ValorCondominio = valorCondominio;
        }

        public int GetAndar()
        {
            return Andar;
        }

        public void SetAndar(int andar)
        {
            Andar = andar;
        }

        public double GetValorCondominio()
        {
            return ValorCondominio;
        }

        public void SetValorCondominio(double valorCondominio)
        {
            ValorCondominio = valorCondominio;
        }

        public override void CalcularValorAluguel()
        {
            var valorAluguel = (TamanhoEmMetros * 40) + (QuantidadeQuartos * 10) + (QuantidadeBanheiros * 5) + ValorCondominio;
            Console.WriteLine($"O valor do aluguel do apartamento é de R${valorAluguel}");
        }
    }
}