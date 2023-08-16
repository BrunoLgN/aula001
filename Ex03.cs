using System;

namespace ex003;

class Program
{
    static void Main(string[] args)
    {
        string[] nome = new string[100];
        float[] preco = new float[100];
        int escolha;
        int cont = 0;
        while(true)
        {
            Console.WriteLine("1. Novo produto");
            Console.WriteLine("2. Mostrar produto");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            escolha = int.Parse(Console.ReadLine());
            if(escolha == 1)
            {
                if(cont < 100)
                {
                    Console.Write("Informe nome do produto: ");
                    nome[cont] = Console.ReadLine();

                    Console.Write("Informe preço do produto: ");
                    preco[cont] = float.Parse(Console.ReadLine());

                    cont++;
                } 
                
            } else if(escolha == 2)
            {
                Console.WriteLine("Produtos: ");
                for(int i = 0; i < cont; i++)
                {
                    Console.WriteLine("nome: {0}", nome[i]);
                    Console.WriteLine("preço: R${0}", preco[i]);
                }
                
            } else if(escolha == 3)
            {   
                break;
            } else 
            {
                Console.WriteLine("Opção invalida");
            }
        }    
    }
}
