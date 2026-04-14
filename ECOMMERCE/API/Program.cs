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

app.MapGet("/api/produto/listar", () =>
{
    if (produtos.Any())
    {
        return Results.Ok(produtos);

    }
    return  Results.NotFound("Lista de produtos vazia!");
});

//post: /API/PRODUTO/CADASTRAR
app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    for (int i = 0; i < produtos.Count; i++)
    {
        if (produtos[i].Nome == produto.Nome)
        {
            return Results.Conflict("Este produto ja existe!");
        }
    }
    produtos.Add(produto);
    return Results.Created("", produto);

});

//GET: /api/produto/buscar/{id}
app.MapGet("/api/produto/buscar/{id}",
(string id) =>

{
    foreach (Produto produtoCadastrado in produtos)
    {
        if (produtoCadastrado.Id == id)
        {
            return Results.Ok(produtoCadastrado);
        }
    }
    return Results.NotFound("Produto não encontrado!");
});

// RODAR A APLICAÇÃO
app.Run();


// ==========================================
// DECLARAÇÃO DA CLASSE NO FINAL DO ARQUIVO
// ==========================================
public class Produto
{
    public Produto()
    {
        CriadoEm = DateTime.Now;
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }

    public DateTime CriadoEm { get; set; } = DateTime.Now;
}