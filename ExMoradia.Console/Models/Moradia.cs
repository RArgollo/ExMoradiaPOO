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

        public Moradia(string endereco, int cep, double tamanhoEmMetros, int quantidadeDeBanheiros, int quantidadeDeQuartos)
        {
            Endereco = endereco;
            CEP = cep;
            TamanhoEmMetros = tamanhoEmMetros;
            QuantidadeBanheiros = quantidadeDeBanheiros;
            QuantidadeQuartos = quantidadeDeQuartos;
            Moradores = new List<Morador>();
        }

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

        public virtual void CalcularValorAluguel()
        {
            var valorAluguel = 0;
        }

        public void AdicionarMorador(Morador morador)
        {
            Console.WriteLine("Digite o nome do Morador");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do Morador (só numeros)");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento do Morador (com /)");
            var dataNascimento = Console.ReadLine();
            var continuar = "0";
            do
            {
                Moradores.Add(new Morador(nome, cpf, dataNascimento));
                Console.WriteLine("Deseja adicionar mais moradores? 1-sim , 2-nao");
                continuar = Console.ReadLine();
            }while(continuar=="1");
        }

        public void RemoverMorador(string cpf)
        {

        }
    }
}