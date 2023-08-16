float nota1, nota2, media;
Console.Write("Informe primeira nota: ");
nota1 = float.Parse(Console.ReadLine());

Console.Write("Informe segunda nota: ");
nota2 = float.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;
if(media >= 7)
{
    Console.WriteLine("Aluno aprovado com média: {0}", media);
} else 
{
    Console.WriteLine("Aluno reprovado com média: {0}", media);
}
Console.ReadKey();