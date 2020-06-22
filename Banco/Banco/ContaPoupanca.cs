using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca: Conta
    {
        public ContaPoupanca() 
        {
        }

        public ContaPoupanca(string numero) : base(numero)
        {
        }

        public ContaPoupanca(string numero, string titular) : base(numero)
        {
        }

        public override void Saca(double valor)
        {

            if (valor <= this.Saldo)
            {
                Saldo -= valor + 0.10;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Saldo Insuficiente!");
            }

        }
        public override void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}
