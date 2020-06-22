using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Cliente
    {
        public String Nome { get; set; }
        public String Rg { get; private set; }
        public String Cpf { get; private set; }
        public String Endereço { get; set; }
        public int Idade { get; set; }

        public bool EhMaiorDeIdade()
        {
            if (this.Idade >= 18)
            {
                return true;
            } return false;
        }

        public Cliente(string nome, string rg)
        {
            this.Nome = nome;
            this.Rg = rg;
        }

        public Cliente(string rg)
        {
            this.Rg = rg;
        }
    }
}
