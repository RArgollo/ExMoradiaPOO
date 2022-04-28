namespace ExMoradiaPOO
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }

        public Casa(string endereco, string cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos, bool comQuintal) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            SetEndereco(endereco);
            SetCEP(cep);
            SetTamanhoEmMetros(tamanhoEmMetros);
            SetQuantidadeBanheiros(quantidadeDeBanheiros);
            SetQuantidadeQuartos(quantidadeDeQuartos);
            SetComQuintal(comQuintal);
        }

        public override void SetQuantidadeBanheiros(int quantidadeBanheiros)
        {
            if (quantidadeBanheiros <= 5)
            {
                QuantidadeBanheiros = quantidadeBanheiros;
            }
        }

        public override void SetTamanhoEmMetros(double tamanhoEmMetros)
        {
            if (tamanhoEmMetros <= 100)
            {
                TamanhoEmMetros = tamanhoEmMetros;
            }
        }

        public bool GetComQuintal()
        {
            return ComQuintal;
        }
        public void SetComQuintal(bool comQuintal)
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