double nota1, nota2, nota3, nota4, media;

string resultado;

Console.WriteLine("-- Média --");

Console.WriteLine("Digite as suas notas abaixo.\n");

Console.WriteLine("Primeira Nota...");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Segunda Nota...");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Terceira Nota...");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quarta Nota.");
nota4 = Convert.ToDouble(Console.ReadLine());


bool NotasValidas = nota1 >= 0 && nota1 <= 10
                 && nota2 >= 0 && nota2 <= 10
                 && nota3 >= 0 && nota3 <= 10
                 && nota4 >= 0 && nota4 <= 10;


if(NotasValidas)
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;

    if (media < 5)
    {
    resultado = "Reprovado";
    }
    else
    
     if (media > 6)
        {
            resultado = "Aprovado";
        }
        else
        {
            resultado = "Em recuperação";
        }

    Console.WriteLine($"Você ficou com a média {media:N1}. Resultado: {resultado}");    
}
else
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}