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

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();

            Conta c1 = new ContaCorrente();
            Cliente cliente1 = new Cliente();
            cliente1.Titular = "Ana";
            c1.Titular = cliente1.Titular;
            this.AdicionaContaNova(c1);

            Conta c2 = new ContaPoupanca();
            Cliente cliente2 = new Cliente();
            cliente2.Titular = "Du";
            c2.Titular = cliente2.Titular;
            this.AdicionaContaNova(c2);

            Conta c3 = new ContaCorrente();
            Cliente cliente3 = new Cliente();
            cliente3.Titular = "Leo";
            c3.Titular = cliente3.Titular;
            this.AdicionaContaNova(c3);
        }

        private void textTitular_TextChanged(object sender, EventArgs e)
        {
        }

        private void textSaldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void Saca_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = (Conta) comboContas.SelectedItem;

            if (!(textValor.Text == ""))
            {
                try
                { 
                    contaSelecionada.Saca(Convert.ToDouble(textValor.Text));
                    textSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
                }
                catch (SaldoInsuficienteException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Entre com o valor!");
            }
        }
        private void Deposita_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = (Conta) comboContas.SelectedItem;

            try
            {
                contaSelecionada.Deposita(Convert.ToDouble(textValor.Text));
                textSaldo.Text = contaSelecionada.Saldo.ToString();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message + "\nArgumento Inválido");
            }
        }

       private void button1_Click(object sender, EventArgs e)
        {
            TotalizadorDeContas t = new TotalizadorDeContas();
            Conta contaSelecionada = (Conta)comboContas.SelectedItem;
            t.Adiciona(contaSelecionada);
            MessageBox.Show(Convert.ToString(t.SaldoTotal));
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta contaSelecionada = (Conta) comboContas.SelectedItem;
            CarregaDados(contaSelecionada);
        }

        private void CarregaDados(Conta contaSelecionada)
        {
            textTitular.Text = contaSelecionada.Titular;
            textSaldo.Text = contaSelecionada.Saldo.ToString();
            textNumero.Text = contaSelecionada.Numero.ToString();
            textTipo.Text = contaSelecionada.getTipo();
        }

        public void AdicionaContaNova(Conta conta)
        {
            this.contas.Add(conta);
            conta.Numero = this.contas.Count();
            comboContas.Items.Add(conta);
            comboContas.DisplayMember = "Titular";
            this.dicionario.Add(conta.Titular, conta);
        }

        private void CriarNovaConta_Click(object sender, EventArgs e)
        {
            CadastroConta novaConta = new CadastroConta(this);
            novaConta.ShowDialog();
        }

        public int getTotalContas()
        {
            return this.contas.Count() + 1;
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            string nomeTitular = textBusca.Text;

            try{
                Conta conta = dicionario[nomeTitular];
                comboContas.SelectedItem = conta;
            } catch (KeyNotFoundException exception)
                {
                    MessageBox.Show("Titular inexistente!\n" + exception.Message);
                }
            }

        private void botaoRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
    }
}
