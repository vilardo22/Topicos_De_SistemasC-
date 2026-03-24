
double cotacaoDollar = 5.17;
double cotacaoEuro = 6.14;
double cotacaoPeso = 0.05;

Console.Write("Qual seu valor em reais (R$)? ");
double reais = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Para qual moeda deseja converter?");
Console.WriteLine("1 - Dólar | 2 - Euro | 3 - Peso Argentino");
string operacao = Console.ReadLine(); 


if (operacao == "1") 
{
    double resultado = ConverterParaDollar(reais, cotacaoDollar);
    Console.WriteLine($"R$ {reais} equivalem a $ {resultado:F2} Dólares.");
}
else if (operacao == "2")
{
    double resultado = ConverterParaEuro(reais, cotacaoEuro);
    Console.WriteLine($"R$ {reais} equivalem a € {resultado:F2} Euros.");
}
else if (operacao == "3")
{
    double resultado = ConverterParaPeso(reais, cotacaoPeso);
    Console.WriteLine($"R$ {reais} equivalem a $ {resultado:F2} Pesos Argentinos.");
}
else 
{
    Console.WriteLine("Opção inválida!");
}


double ConverterParaDollar(double r, double d) => r / d;
double ConverterParaEuro(double r, double e) => r / e;
double ConverterParaPeso(double r, double p) => r / p;

