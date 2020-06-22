using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi Ana! :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadeEduardo = 33;
            int idadeMedia;

            idadeMedia = (idadeJoao + idadeMaria + idadeEduardo) / 2;

            String mediaString = Convert.ToString(idadeMedia);

            MessageBox.Show("O resultado é: " + mediaString);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 5;
            int c = 2;
            double delta, a1, a2;

            delta = b*b - 4*a*c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("O resultado é: " + a1 + "e" + a2);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idade = 20;
            bool brasileira = true;

            if(idade >= 18 && brasileira)
            {
                MessageBox.Show("Você pode votar!");
            }
            else
            {
                MessageBox.Show("Você NÃO pode votar!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 5000.00;
            double imposto;

            if (valorDaNotaFiscal <= 999.00)
            {
                imposto = 0.02;
            }
            else if (valorDaNotaFiscal >= 1000.00 && valorDaNotaFiscal <= 2999.00)
            {
                imposto = 0.025;
            }
            else if (valorDaNotaFiscal >= 3000.00 && valorDaNotaFiscal <= 6999.00)
            {
                imposto = 0.028;
            }
            else
            {
                imposto = 0.03;
            }

            MessageBox.Show("O imposto a pagar é: " + imposto*100 +"%");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem;

            mensagem = (valor > 10 ? "Maior que dez" : "Menor que dez");

            MessageBox.Show("A resposta é : " + mensagem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i= 1; i <= 1000; i++) {
                soma = soma + i;
            }
            MessageBox.Show("A soma é: " + soma);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int numero = 0;

            for (int i = 1; i <= 100; i++)
            {
                numero = i;
                if (numero % 3 == 0)
                {
                    MessageBox.Show("Múltiplo: " + numero);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                numero = i;
                if (numero % 3 != 0)
                {
                    soma = soma + numero;
                }
            }
            MessageBox.Show("A soma sem os multiplos: " + soma);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int numero = 0;
            String numeroString="";

            for (int i = 0; i <= 30; i++)
            {
                numero = i;
                if (numero % 3 == 0 || numero % 4 == 0)
                {
                    numeroString = numeroString + " " +Convert.ToString(numero);
                }
            }
            MessageBox.Show("Divisíveis: " + numeroString);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            long fatorial = 1;

            for (int n = 1; n <= 10; n++) {

                fatorial = n * fatorial; 

                MessageBox.Show("O fatorial de : " + n + " é: " + fatorial);

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            long ant = 0;
            long atual = 1;

            while (atual < 100)
            {
                MessageBox.Show("Numeros Fibonacci: " + atual);
                atual = ant + atual;
                ant = atual - ant;
             }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente("Ana", "123456");
            conta.Titular = cliente;
            conta.Numero = "98765";
            
            MessageBox.Show("Saldo Antes do Depósito: " + conta.Saldo);
            conta.Deposita(100);
            MessageBox.Show("Saldo Pos-Depósito: " + conta.Saldo);

            if (conta.Saca(50))
            {
                MessageBox.Show("Saque realizado com sucesso, Saldo final: " + conta.Saldo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente: " + conta.Saldo);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int numero2 = 0;

            for (int i=0; i<=100; i++)
            {
                for (int j=0; j<=100; j++)
                {
                    MessageBox.Show(Convert.ToString(i), Convert.ToString(j));
                }
            }

        }
    }
}
