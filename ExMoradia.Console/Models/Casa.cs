namespace ExMoradiaPOO
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }

        public Casa(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos, bool comQuintal) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            Endereco = endereco;
            CEP = cep;
            TamanhoEmMetros = tamanhoEmMetros;
            QuantidadeBanheiros = quantidadeDeBanheiros;
            QuantidadeQuartos = quantidadeDeQuartos;
            ComQuintal = comQuintal;
        }

        public bool GetComQuntal()
        {
            return ComQuintal;
        }
        public void SetComQuntal(bool comQuintal)
        {
            ComQuintal = comQuintal;
        }

        public override void CalcularValorAluguel()
        {
            var valorAluguel = (TamanhoEmMetros * 35) + (QuantidadeQuartos * 10) + (QuantidadeBanheiros * 5);
            if (ComQuintal == true)
            {
                valorAluguel = valorAluguel + (0.1 * valorAluguel);
            };
            Console.WriteLine($"O valor do aluguel da casa é de R${valorAluguel}");
        }
    }
}