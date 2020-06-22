using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
        }

        public ContaCorrente(string numero) : base(numero)
        {
        }

        public ContaCorrente(string numero, string titular) : base(numero, titular)
        {
        }

        public override void Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                Saldo -= valor + 0.05;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Saldo Insuficiente!");
            }
        }

        public override void Deposita(double valor)
        {
            Saldo += valor - 0.10;
        }
    }
}
