using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {

        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            IEnumerable<Conta> listaFiltrada = contas.Where(c => c.Saldo > 500).OrderBy(c => c.Titular).ThenBy(c => c.Numero);

            foreach (Conta c in listaFiltrada)
            { 
                listaResultado.Items.Add(c.Titular);
            }

            double saldoTotal = listaFiltrada.Sum(conta => conta.Saldo);
            double maiorSaldo = listaFiltrada.Max(conta => conta.Saldo);

            labelSaldoTotal.Text = saldoTotal.ToString();
            labelMaiorSaldo.Text = maiorSaldo.ToString();
        }

        private void listaResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            IEnumerable<Conta> antigas = contas.Where(c => c.Numero < 1000).OrderByDescending(c => c.Titular).ThenBy(c => c.Numero);

            foreach (Conta c in antigas)
            {
                listaResultado.Items.Add(c.Titular);
            }
        }
    }
    }

