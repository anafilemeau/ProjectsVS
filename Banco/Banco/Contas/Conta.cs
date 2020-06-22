namespace Banco.Contas
{
    public abstract class Conta
    {
        public string Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public Conta(int numero,string titular): this(numero)
        {
            this.Titular = titular;
        }

        public abstract void Saca(double valor);

        public abstract void Deposita(double valor);

        public string getTipo()
        {
            return this.GetType().Name;
        }

     //   public override string ToString()
     //   {
     //       return "Titular: " + this.Titular;
    //    }
    }
}