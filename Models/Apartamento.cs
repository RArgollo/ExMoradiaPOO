namespace ExMoradiaPOO
{
    public class Apartamento
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }

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


        public override double CalcularValorAluguel()
        {
            return;
        }
    }
}