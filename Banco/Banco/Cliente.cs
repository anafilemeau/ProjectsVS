namespace Banco
{
    public class Cliente
    {
        public string Titular { get; set; }

        public Cliente()
        {

        }
        public Cliente(string titular)
        {
            this.Titular = titular;
        }
    }
}