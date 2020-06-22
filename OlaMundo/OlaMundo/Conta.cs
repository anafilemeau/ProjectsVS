using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Conta

    {
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public String Numero { get; set; }
        public int Idade { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (this.Idade < 18 && valor > 200)
            {
                return false;
            } else { 
                if (this.Saldo >= valor)
                {
                    this.Saldo -= valor;
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
