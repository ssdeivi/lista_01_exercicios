/*
 
 Desenvolva um programa que solicite a idade de uma pessoa e 
determine se ela é maior de idade (18 anos ou mais) ou menor de idade. 
Utilize if e else para mostrar a mensagem apropriada.
 
 
 */

Console.WriteLine("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Clear();

if (idade >= 18)
{
    Console.WriteLine($"Você tem {idade} anos, você já é maior de idade!");
}
else
{
    Console.WriteLine($"Você tem {idade} anos, você é menor de idade!");
}



