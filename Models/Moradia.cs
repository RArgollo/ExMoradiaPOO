namespace ExMoradiaPOO
{
    public class Moradia
    {
        protected string Endereco { get; set; }
        protected int CEP { get; set; }
        protected double TamanhoEmMetros { get; set; }
        protected int QuantidadeBanheiros { get; set; }
        protected int QuantidadeQuartos { get; set; }
        protected List<Morador> Moradores { get; set; }

        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }

         public string GetEndereco()
        {
            return Endereco;
        }

        public void SetCEP(int cep)
        {
            CEP = cep;
        }

         public int GetCEP()
        {
            return CEP;
        }

        public void SetTamanhoEmMetros(double tamanhoEmMetros)
        {
            TamanhoEmMetros = tamanhoEmMetros;
        }

         public double GetTamanhoEmMetros()
        {
            return TamanhoEmMetros;
        }

        public void SetQuantidadeBanheiros(int quantidadeBanheiros)
        {
            QuantidadeBanheiros = quantidadeBanheiros;
        }

         public int GetQuantidadeBanheiros()
        {
            return QuantidadeBanheiros;
        }

        public void SetQuantidadeQuartos(int quantidadeQuartos)
        {
            QuantidadeQuartos = quantidadeQuartos;
        }

          public int GetQuantidadeQuartos()
        {
            return QuantidadeQuartos;
        }

        public virtual double CalcularValorAluguel()
        {
            var valorAluguel = 0;
            return valorAluguel;
        }

        public void AdicionarMorador(Morador morador)
        {

        }

        public void RemoverMorador(string cpf)
        {

        }
    }
}