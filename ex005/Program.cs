using System;

int num;
int fatorial = 1;

Console.WriteLine("Informe um numero: ");

while (true)
{
    num = int.Parse(s: Console.ReadLine());
    if (num < 0)
    {
        Console.WriteLine("Numero invalido, informe outro: ");
        continue;
    }
    else
    {
        break;
    }
}

for (int i = 2; i <= num; i++)
{
    fatorial *= i;
}
Console.WriteLine(fatorial);
