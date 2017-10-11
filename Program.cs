using System;
using System.IO;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, email;
            int idade;

            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine().ToLower();

            Console.WriteLine("Informe o seu email: ");
            email = Console.ReadLine().ToLower();

            Console.WriteLine("Informe a sua idade: ");
            idade = Int16.Parse(Console.ReadLine());

            //usar crtl e . para achar a biblioteca do comando caso você não saiba;
            // true adiciona as linhas no arquivo já existente, sobrescreve.
            StreamWriter arquivo = new StreamWriter("dados.csv", true);
            //if (arquivo.)
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            
            
            arquivo.Close();




        }
    }
}
