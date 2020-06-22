namespace Banco
{
    public class TipoConta
    {
        public string Tipo { get; set; }

        public TipoConta()
        {
        }
        public TipoConta(string tipo)
        {
            this.Tipo = tipo;
        }
    }
}