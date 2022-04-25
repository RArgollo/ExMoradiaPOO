namespace ExMoradiaPOO
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }

          public bool GetComQuntal()
        {
            return ComQuintal;
        }

          public void SetComQuntal(bool comQuintal)
        {
            ComQuintal = comQuintal;
        }

        public override double CalcularValorAluguel()
        {
            return;
        }
    }
}