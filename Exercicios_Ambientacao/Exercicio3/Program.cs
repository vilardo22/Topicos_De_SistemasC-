int n1; // Declaração da variável
int n2;

Console.Write("Insira o 1° valor: ");
// Aqui tiramos o "int" da frente, pois ela já foi declarada acima
n1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Insira o 2° valor: ");
n2 = Convert.ToInt32(Console.ReadLine());

// Estrutura completa de comparação
if (n1 < n2)
{
    Console.WriteLine($"O maior é {n2} e o menor é {n1}.");
}
else if (n2 < n1)
{
    Console.WriteLine($"O maior é {n1} e o menor é {n2}.");
}
else 
{
    // Caso os números sejam iguais
    Console.WriteLine("Os números são iguais!");
}