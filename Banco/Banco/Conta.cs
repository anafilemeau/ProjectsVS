namespace Banco
{
    public abstract class Conta
    {

        public string Titular { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; protected set; }
        public TipoConta Tipo { get; set; }

        public Conta()
        {
        }

        public Conta(string numero)
        {
            this.Numero = numero;
        }
        public Conta(string numero,string titular): this(numero)
        {
            this.Titular = titular;
        }

        public abstract void Saca(double valor);

        public abstract void Deposita(double valor);

    }
}