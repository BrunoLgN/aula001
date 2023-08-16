using System;

namespace ex006
{
    class Ex06
    {
        static void Main(string[] args)
        {
            int[] num = new int[100];
            int cont = 0;

            Console.WriteLine("Informe um inteiro: (Para encerrar dgite um negativo)");

            for (int i = 0; i < 100; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] < 0)
                {
                    break;
                }
                cont++;
            }

            Console.WriteLine("Números digitados:");

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
