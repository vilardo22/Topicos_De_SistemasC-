var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var produtos = new List<Produto>
{
    new Produto { Nome = "Notebook" },
    new Produto { Nome = "Smartphone" },
    new Produto { Nome = "Teclado" },
    new Produto { Nome = "Mouse" },
    new Produto { Nome = "Monitor" },
    new Produto { Nome = "Headset" },
    new Produto { Nome = "Webcam" },
    new Produto { Nome = "Impressora" },
    new Produto { Nome = "Tablet" },
    new Produto { Nome = "HD Externo" }
};

// Endpoints
app.MapGet("/", () => "API de Produtos!");

app.MapGet("/api/produto/listar", () => {
    return produtos;
});

//post: /API/PRODUTO/CADASTRAR
app.MapPost("/api/produto/cadastrar", () =>
{
    Produto produto1 = new Produto
    {
        Nome = "MousePad"
    };
   

    Produto produto2 = new Produto();
    produto2.Nome = "Cooler";
    produtos.Add(produto1);
    produtos.Add(produto2);


});


// RODAR A APLICAÇÃO
app.Run();


// ==========================================
// DECLARAÇÃO DA CLASSE NO FINAL DO ARQUIVO
// ==========================================
public class Produto
{
    public string Nome { get; set; }
}