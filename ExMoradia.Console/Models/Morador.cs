namespace ExMoradiaPOO
{
    public class Morador
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private DateTime DataNascimento { get; set; }

        public Morador(string nome, string cpf, string dataNascimento)
        {
            Nome = nome;
            CPF = cpf; 
            DataNascimento = DateTime.Parse(dataNascimento);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }

         public string GetCPF()
        {
            return CPF;
        }

         public void SetDataNascimento(string dataNascimento)
        {
            DataNascimento = DateTime.Parse(dataNascimento);
        }

         public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }

    }
}