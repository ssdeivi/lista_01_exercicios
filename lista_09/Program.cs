/*
 
 Desenvolva um programa que peça um número de 1 a 7 e exiba 
o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", 
etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de 
erro.
 
 */

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

if (n == 1)
{
    Console.WriteLine($"O número {n} corresponde ao domingo.");
}
else if (n == 2)
{
    Console.WriteLine($"O número {n} corresponde à segunda.");
}
else if (n == 3)
{
    Console.WriteLine($"O número {n} corresponde à terça.");
}
else if (n == 4)
{
    Console.WriteLine($"O número {n} corresponde à quarta.");
}
else if (n == 5)
{
    Console.WriteLine($"O número {n} corresponde à quinta.");
}
else if (n == 6)
{
    Console.WriteLine($"O número {n} corresponde à sexta.");
}
else if (n == 7)
{
    Console.WriteLine($"O número {n} corresponde à sábado");
}
else
{
    Console.WriteLine("erro");
}