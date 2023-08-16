using System;

namespace ex003;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        int palpite;
        int chances = 0;

        while(true)
        {
            Console.WriteLine("Informe seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            if(chances == 10)
            {
                Console.WriteLine("Chances esgotadas, você perdeu!");
                break;
            }
            if(palpite == randomNumber)
            {
                Console.WriteLine("Parabens você acertou!");
                break;
            } else
            {
                if(palpite > randomNumber)
                {
                    Console.WriteLine("Muito Alto");
                    chances++;
                    continue;
                } else if(palpite < randomNumber)
                {
                    Console.WriteLine("Muito baixo");
                    chances++;
                    continue;
                }
            }

        } 
    }
}
