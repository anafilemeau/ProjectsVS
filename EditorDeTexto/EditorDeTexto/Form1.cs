using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using (Stream entrada = File.Open("texto.txt", FileMode.Open))
                {
                    using (TextReader leitor = new StreamReader(entrada))
                    {
                        string todasLinhas = leitor.ReadToEnd();
                        // while(linha != null)
                        //  {
                        textoConteudo.Text = todasLinhas;
                        //linha = leitor.ReadLine();
                        //  }
                        //  leitor.Close();
                        //  entrada.Close();
                    }
                }
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            gravaTexto();
        }

        private void gravaTexto()
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(saida))
                {
                    escritor.Write(textoConteudo.Text);
                }
            }

        }

        private string buscarTexto()
        {
            string palavra = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;

            int resultado = textoDoEditor.IndexOf(palavra);
            if (resultado >= 0)
            {
                return palavra;
            }
            else
            {
                return "Termo não encontrado!";
            }
        }

        private void substituirPalavra()
        {
            string palavra = buscarTexto();
            string palavraNova = textoReplace.Text;
            string textoDoEditor = textoConteudo.Text;
            
            int posicaoPalavra = textoDoEditor.IndexOf(palavra);

            string inicioPalavraAntiga = textoDoEditor.Substring(posicaoPalavra);

            string textoNovo = inicioPalavraAntiga.Replace(palavra,palavraNova);

            textoDoEditor = textoDoEditor.Replace(inicioPalavraAntiga,textoNovo);

            textoConteudo.Text = textoDoEditor;

            gravaTexto();

        }

       private void transformarMaiusculas()
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            string textoSelecionado = textoConteudo.Text
                .Substring(inicioSelecao, tamanhoSelecao);

            string antes = textoConteudo.Text.Substring(0,inicioSelecao);

            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;

            //string textoDoEditor = textoConteudo.Text;
            //textoDoEditor = textoDoEditor.ToUpper();
            //textoConteudo.Text = textoDoEditor;
            gravaTexto();
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            String palavra = buscarTexto();
            if (!palavra.Equals("Termo não encontrado!"))
            {
                botaoReplace.Enabled=true;
                textoReplace.Enabled=true;
            }
        }

        private void botaoReplace_Click(object sender, EventArgs e)
        {
            substituirPalavra();
        }

        private void textoConteudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpper_Click(object sender, EventArgs e)
        {
            transformarMaiusculas();
        }

        private void buttonLower_Click(object sender, EventArgs e)
        {
            transformarMinusculas();
        }

        private void transformarMinusculas()
        {
            //string textoDoEditor = textoConteudo.Text;
            //textoDoEditor = textoDoEditor.ToLower();
            //textoConteudo.Text = textoDoEditor;

            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            string textoSelecionado = textoConteudo.Text
                .Substring(inicioSelecao, tamanhoSelecao);

            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

            textoConteudo.Text = antes + textoSelecionado.ToLower() + depois;
            
            gravaTexto();
        }
    }
}
