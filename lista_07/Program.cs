/*
 
 Escreva um programa que solicita dois números ao usuário e 
determina qual deles é maior. Utilize if, else if e else para exibir a mensagem 
adequada.
 
 
 */

Console.WriteLine("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int n2 = int.Parse(Console.ReadLine());

Console.Clear();

if (n1 > n2)
{
    Console.WriteLine($"O número {n1} é maior que {n2}.");
}
else if (n2 > n1)
{
    Console.WriteLine($"O número {n2} é maior que {n1}.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}