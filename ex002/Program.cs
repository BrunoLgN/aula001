namespace orientacao_objetos;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Informe um numero: ");
        num = int.Parse(Console.ReadLine());
        if(num < 0)
        {
            Console.WriteLine("ERRO");
        }

        
        while(num >= 0)
        {
            Console.WriteLine(num + "...");
            num--;
        }
    }
}
