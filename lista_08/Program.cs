/*
 
Crie um programa que pergunte a idade de uma pessoa e 
determine se ela pode votar (idade >= 16). Utilize uma condição if para exibir 
a mensagem correspondente.
 
 */

Console.WriteLine("Qual a sua idade ? ");
int idade = int.Parse(Console.ReadLine());

Console.Clear();

if (idade >= 16)
{
    Console.WriteLine($"Com {idade} anos, você já pode votar!");
}
else
{
    Console.WriteLine($"Com {idade} anos, você não pode votar!");
}
