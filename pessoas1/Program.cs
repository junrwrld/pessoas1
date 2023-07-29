using System;
using System.Globalization;

namespace pessoas1
{
    public class _pessoas
    {
        static void Main(string[] args)
        {

            Pessoas pessoa1;
            Pessoas pessoa2;

            pessoa1 = new Pessoas();
            pessoa2 = new Pessoas();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            pessoa1.pessoaNome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            pessoa1.pessoaIdade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da primeira pessoa:");
            pessoa2.pessoaNome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            pessoa2.pessoaIdade = int.Parse(Console.ReadLine());

            if (pessoa1.pessoaIdade > pessoa2.pessoaIdade)
            {
                Console.WriteLine("A " + pessoa1.pessoaNome + " é mais velha que " + pessoa2.pessoaNome);
            }
            else
            {
                Console.WriteLine("A " + pessoa2.pessoaNome + " é mais velha que " + pessoa1.pessoaNome);

            }
        }
    }
}