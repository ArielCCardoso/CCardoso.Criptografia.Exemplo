using System;
using System.IO;

namespace CCardoso.Criptografia.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\..\..\..\";
            CryptRsa.PrivateKey = path + "private.pem";
            CryptRsa.PublicKey = path + "public.pem";

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Informe a opção desejada: \n1 - criptografar\n2 - descriptografar\n3 - sair");
                var op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Clear();
                    Console.Write("Informe o texto para criptografar: ");
                    var text = Console.ReadLine();
                    Console.WriteLine($"Texto criptografado:\n{CryptRsa.Encrypt(text)}");
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.Write("Informe o texto para descriptografar: ");
                    var text = Console.ReadLine();
                    Console.WriteLine($"Texto descriptografado:\n{CryptRsa.Decrypt(text)}");
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Opção inválida!\nTecle para continar...");
                    Console.ReadKey();
                }
            }
        }
    }
}