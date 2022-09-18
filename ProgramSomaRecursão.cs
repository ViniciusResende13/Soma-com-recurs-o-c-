using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_elementos_com_recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite o tamanho do vetor: ");
            n=int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            Console.WriteLine("\nPreencha o vetor: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nA soma é: ");
            Console.WriteLine(somavetor(vetor,n));
            Console.ReadLine();
        }
        static int somavetor(int[] v, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return v[n - 1] + somavetor(v, n - 1);
            }
        }
    }
}
