Console.Write("Digite um número limite para a sequência: ");
int limite = Convert.ToInt32(Console.ReadLine());

int anterior = 0;
int atual = 1;

Console.WriteLine("Sequência de Fibonacci:");

// 1. O primeiro número sempre é 0, então já imprimimos ele
Console.Write(anterior);

// 2. Enquanto o próximo número for menor ou igual ao limite do usuário
while (atual <= limite)
{
    // Imprime o número atual da sequência
    Console.Write(", " + atual);

    // 3. A MÁGICA: Precisamos calcular o próximo e "andar" com as variáveis
    int proximo = anterior + atual; 
    anterior = atual; // O que era atual agora vira o anterior
    atual = proximo;  // O atual agora é a soma que acabamos de fazer
}

Console.WriteLine("."); // Só para fechar a frase com um ponto final