/*
 
 Escreva um programa que peça o valor de uma compra e 
verifique se o valor é maior que 100. Se sim, aplique um desconto de 10% 
no valor e mostre o valor final. Caso contrário, exiba o valor original.
 
 */

Console.WriteLine("Qual o valor da compra? ");
float valor = float.Parse(Console.ReadLine());

float desconto = valor - (valor * 10 / 100);

Console.Clear();

if (valor > 100)
{
    Console.WriteLine("Você recebeu um desconto de 10%");
    Console.WriteLine($"Valor antes do desconto: {valor} R$");
    Console.WriteLine($"Valor com desconto: {desconto} R$");
}
else
{
    Console.WriteLine($"O valor da sua compra foi {valor} R$");
}