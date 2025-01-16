/*
  Escreva um programa que pergunte a nota de um aluno. Se a 
nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso 
contrário, ele é "Reprovado". Exiba a situação do aluno na tela.

 */

Console.WriteLine("Qual a sua nota ? ");
double nota = double.Parse(Console.ReadLine());

Console.Clear();

if (nota >= 6)
{
    Console.WriteLine("Você está aprovado!");
}
else
{
    Console.WriteLine("Você está reprovado!");
}