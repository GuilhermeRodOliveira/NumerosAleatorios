using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace ESTRUTURA_LOOP_DE_REPETIÇÃO_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //9 - Crie um programa que gere e imprima uma sequência de números aleatórios entre 1 e 100 usando um loop for.

            Console.WriteLine("Vou criar ma sequência de números aleatórios entre 1 e 100.");
            Console.ReadKey();
            Console.Clear();

            for (int i = 1; i <= 10; i++)
            {
                Random random = new Random();
                int numAleatorio = random.Next(0, 101);
                Console.WriteLine("Número aleatório: " + numAleatorio);
                Thread.Sleep(1000);
            }
        }
    }
}
