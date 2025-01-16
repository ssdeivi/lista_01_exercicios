/*
 
 Crie um programa que verifique se um número digitado pelo 
usuário está dentro do intervalo de 1 a 100. Utilize uma condição if para 
verificar se o número está no intervalo e exiba uma mensagem informando 
o resultado.
 
 */

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine());

Console.Clear();

if (n >= 1 && n <= 100)
{
    Console.WriteLine($"O número {n} está entre 1 e 100");
}
else
{
    Console.WriteLine($"o número {n} não está entre 1 e 100");
}
