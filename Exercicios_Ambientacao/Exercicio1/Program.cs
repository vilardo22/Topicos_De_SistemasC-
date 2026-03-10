//Exercicio 01
//Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.
// See https://aka.ms/new-console-template for more information



        double altura;
        double largura;
        double area;

        Console.Write("Digite a altura do retângulo: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a largura do retangulo: ");
        largura = Convert.ToDouble(Console.ReadLine());

        area = altura * largura;
        Console.WriteLine("A área do retângulo é: " + area);
