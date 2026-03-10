//Passo a passo para resolver o exercicio
//Exercício 06
//Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.
//1. Desenvolver o algoritmo de ordenação (Bubble Sort);
//2. Utilizar uma função em C# para ordenação;
//1 criar um vetor de valores inteiros com N posicoes
//2 - Criar um laço de repetição para percorrer o vetor
//3 - Atribuir um valor aleatorio para cada posicao
//4- Imprimir o Vetor sem ordenaçao


int[] vetor = new int[100];

for (int i = 0; i < vetor.Length; i++)
{
    Random random = new Random();
    vetor[i] = random.Next(1000);

}
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}
//Passo a Passo
    //1 - Criar um laço de repetição para percorrer o vetor
    //2 -Comparar a posição atual com a proxima
    //3- Se for maior vai trocar o valores
//4- Repetir o processo até ordenar o vetor