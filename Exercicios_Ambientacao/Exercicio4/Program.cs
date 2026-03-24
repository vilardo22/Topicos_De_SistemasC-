int idade;

Console.Write("Qual a sua idade? ");
idade = Convert.ToInt32(Console.ReadLine()); // Usando Int32 que é o padrão

if (idade <= 13)
{
    Console.WriteLine("Criança: Acesso Negado.");
}
else if (idade <= 18) 
{
    // Se chegou aqui, o C# já sabe que a idade é MAIOR que 13.
    // Então só precisamos testar se é MENOR ou IGUAL a 18.
    Console.WriteLine("Adolescente: Opções limitadas disponíveis.");
}
else if (idade <= 60)
{
    // Se chegou aqui, ele já sabe que é MAIOR que 18.
    // Testamos apenas se é MENOR ou IGUAL a 60.
    Console.WriteLine("Adulto: Acesso total liberado.");
}
else 
{
    // Se não caiu em nenhuma das anteriores, só pode ser maior que 60.
    Console.WriteLine("Idoso: Acesso total e prioridade.");
}