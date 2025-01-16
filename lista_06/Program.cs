/*
 
 Crie um programa que peça a nota de um aluno e classifique a 
nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" 
(5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela.
 
 */

Console.WriteLine("Qual foi a sua nota? ");
float nota = float.Parse(Console.ReadLine());

Console.Clear();

if (nota >= 9)
{
    Console.WriteLine($"Sua nota foi {nota}, uma nota excelente!");
}
else if (nota < 9 && nota >= 7)
{
    Console.WriteLine($"Sua nota foi {nota}, uma nota boa!");
}
else if (nota < 7 && nota >= 5)
{
    Console.WriteLine($"Sua nota foi {nota}, uma nota regular!");
}
else
{
    Console.WriteLine($"Sua nota foi {nota}, uma nota baixa!");
}