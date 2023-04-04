using System;
using System.Globalization;

namespace CsE15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 15
            int senha = 2002; //Senha correta
            int entrada = 0;
            Console.WriteLine("Informe a senha correta\n\nSENHA:");
            entrada = int.Parse(Console.ReadLine());
            while (entrada != senha) 
            {
                Console.Clear();
                Console.WriteLine("\nSenha Inválida!\n");
                Console.WriteLine("Informe a senha correta\n\nSENHA:");
                entrada = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Acesso Permitido!\nFim do Programa!\n");
        }
    }
}
