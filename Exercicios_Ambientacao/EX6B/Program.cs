// 1 criar um vetor de valores inteiros com N posicoes
int[] vetor = new int[100]; 
Random random = new Random();

// 2 - Criar um laço de repetição para percorrer o vetor e preencher
for (int i = 0; i < vetor.Length; i++)
{
    // 3 - Atribuir um valor aleatorio para cada posicao
    vetor[i] = random.Next(1000);
}

// 4 - Imprimir o Vetor sem ordenaçao
Console.WriteLine("Vetor original (desordenado):");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine("\n"); 

// --- ORDENAÇÃO NATIVA DO C# ---
// Substitui todos os laços de repetição do algoritmo manual
Array.Sort(vetor);

// Imprimir o vetor após a ordenação
Console.WriteLine("Vetor ordenado com Array.Sort:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();