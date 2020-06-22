using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader leitor = Console.In)
            {
                string linha = "";
                while (linha != null)
                {
                    linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }
        }
    }
}
