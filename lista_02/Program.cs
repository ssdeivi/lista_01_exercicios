/*
 
  Desenvolva um programa que solicita ao usuário um número. O 
programa deve determinar se o número é positivo, negativo ou zero, 
utilizando if, else if, e else para as três possibilidades. Exiba a mensagem 
correspondente
 
 */

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

if (n > 0)
{
    Console.WriteLine($"O número {n} é positivo");
}
else if (n < 0)
{
    Console.WriteLine($"O número {n} é negativo");
}
else
{
    Console.WriteLine($"O número é {n}");
}