namespace ExMoradiaPOO
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }

        public Apartamento(string endereco, string cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos, int andar, double valorCondominio) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            SetEndereco(endereco);
            SetCEP(cep);
            SetTamanhoEmMetros(tamanhoEmMetros);
            SetQuantidadeBanheiros(quantidadeDeBanheiros);
            SetQuantidadeQuartos(quantidadeDeQuartos);
            SetAndar(andar);
            SetValorCondominio(valorCondominio);
        }

        public override void SetQuantidadeBanheiros(int quantidadeBanheiros)
        {
            if (quantidadeBanheiros <= 3)
            {
                QuantidadeBanheiros = quantidadeBanheiros;
            }
        }

        public override void SetTamanhoEmMetros(double tamanhoEmMetros)
        {
            if (tamanhoEmMetros <= 60)
            {
                TamanhoEmMetros = tamanhoEmMetros;
            }

        }

        public int GetAndar()
        {
            return Andar;
        }

        public void SetAndar(int andar)
        {
            if (andar <= 10)
            {
                Andar = andar;
            }
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