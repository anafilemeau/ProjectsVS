using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Busca;

namespace Banco
{
    public partial class CadastroConta : Form
    {
        private ICollection<string> devedores;
        private Form1 formPrincipal;
        private TipoConta[] tiposContas;
        Conta novaConta;
        
        public CadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void CadastroConta_Load(object sender, EventArgs e)
        {
            tiposContas = new TipoConta[2];

            TipoConta t1 = new TipoConta("ContaCorrente");
            this.AdicionaTipoConta(t1);

            TipoConta t2 = new TipoConta("ContaPoupanca");
            this.AdicionaTipoConta(t2);

            textoNumero.Text = formPrincipal.getTotalContas().ToString();
        }

        private void AdicionaTipoConta(TipoConta tipo)
        {
            this.tiposContas[TipoConta.numeroDeTipos - 1] = tipo;
            comboTipoConta.Items.Add(tipo);
            comboTipoConta.DisplayMember = "Tipo";
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool eDevedor = false;
            
            for(int i = 0; i < 30000; i++)
            {

                eDevedor = this.devedores.Contains(titular);
            }

            if (!eDevedor) { 
                if (!(textoTitular.Text == "") && !(textoNumero.Text == "") 
                    && !(comboTipoConta.Text == ""))
                {
                   if (comboTipoConta.Text == "ContaCorrente") {
                        novaConta = new ContaCorrente();
                    }
                   if (comboTipoConta.Text == "ContaPoupanca") {
                        novaConta = new ContaPoupanca();
                    }
                    novaConta.Titular = textoTitular.Text;
                    novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                    this.formPrincipal.AdicionaContaNova(novaConta);
                    MessageBox.Show("Conta Adicionada com Sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha os Dados!");
                }
            }
            else {
                    MessageBox.Show("Devedor!");
                }
        }

        private void CarregaDados(TipoConta tipoSelecionado)
        {
            comboTipoConta.Text = tipoSelecionado.Tipo.ToString();
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoConta tipoSelecionado = (TipoConta) comboTipoConta.SelectedItem;
            CarregaDados(tipoSelecionado);
        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {}
    }
}
