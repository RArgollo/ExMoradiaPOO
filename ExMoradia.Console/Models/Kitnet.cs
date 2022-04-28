namespace ExMoradiaPOO
{
    public class Kitnet : Moradia
    {
        public Kitnet(string endereco, string cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos) : base(endereco, cep, tamanhoEmMetros, quantidadeDeBanheiros, quantidadeDeQuartos)
        {
            SetEndereco(endereco);
            SetCEP(cep);
            SetTamanhoEmMetros(tamanhoEmMetros);
            SetQuantidadeBanheiros(quantidadeDeBanheiros);
            SetQuantidadeQuartos(quantidadeDeQuartos);
        }

        public override void SetTamanhoEmMetros(double tamanhoEmMetros)
        {
            if (tamanhoEmMetros <= 50)
            {
                TamanhoEmMetros = tamanhoEmMetros;
            }
        }

        public override void SetQuantidadeBanheiros(int quantidadeBanheiros)
        {
            if (quantidadeBanheiros <= 2)
            {
                QuantidadeBanheiros = quantidadeBanheiros;
            }
        }

        public override void CalcularValorAluguel()
        {
            var valorAluguel = TamanhoEmMetros * 30;
            Console.WriteLine($"O valor do aluguel da kitnet é de R${valorAluguel}");
        }
    }
}