namespace ExMoradiaPOO
{
    public class Morador
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private DateTime DataNascimento { get; set; }

        public Morador(string nome, string cpf, string dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
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
            if (cpf.Length == 11)
            {
                CPF = cpf;
            } else
            CPF = "";
        }

        public string GetCPF()
        {
            return CPF;
        }

        public void SetDataNascimento(string dataNascimento)
        {
            if(DateTime.Parse(dataNascimento)<DateTime.Now)
            {
            DataNascimento = DateTime.Parse(dataNascimento);
            }
        }

        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }

    }
}