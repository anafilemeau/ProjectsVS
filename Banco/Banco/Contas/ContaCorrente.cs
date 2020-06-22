using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
        }

        public ContaCorrente(int numero) : base(numero)
        {
        }

        public ContaCorrente(int numero, string titular) : base(numero, titular)
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
                throw new SaldoInsuficienteException("Saldo Insuficiente.");
            }
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                Saldo += valor - 0.10;
            }
        }
    }
}
