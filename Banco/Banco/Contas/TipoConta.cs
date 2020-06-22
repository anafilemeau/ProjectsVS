namespace Banco.Contas
{
    public class TipoConta
    {
        public string Tipo { get; set; }
        public static int numeroDeTipos { get; private set; }


        public TipoConta()
        {
        }
        public TipoConta(string tipo)
        {
            this.Tipo = tipo;
            TipoConta.numeroDeTipos++;
        }
    }
}