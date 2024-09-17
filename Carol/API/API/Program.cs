// Minimal APIs C#
// Testar a API 
// -Rest Client- Extenção VS code
//- Postman
//- Insonia
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//Endpoits - Funcionalidade
//requisição- URL, metodo/verbo HTTP
//app.MapGet("/", () => "Hello World!");

//app.MapGet("/segundafuncionalidade", () => "segunda funalidade!");

//app.Run();


//Minimal APIs em C#
//Testar a API
// - Rest Client - Extensão VS Code
// - Postman
// - Insomnia
using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Apple iPhone 14", Valor = 999.99, Quantidade = 10 },
    new Produto { Nome = "Samsung Galaxy S23", Valor = 899.99, Quantidade = 5 },
    new Produto { Nome = "Sony WH-1000XM5", Valor = 349.99, Quantidade = 20 },
    new Produto { Nome = "Dell XPS 13", Valor = 1199.99, Quantidade = 8 },
    new Produto { Nome = "Apple MacBook Pro", Valor = 2399.99, Quantidade = 15 },
    new Produto { Nome = "Bose QuietComfort 35 II", Valor = 299.99, Quantidade = 12 },
    new Produto { Nome = "Nintendo Switch", Valor = 299.99, Quantidade = 7 },
    new Produto { Nome = "GoPro HERO10", Valor = 499.99, Quantidade = 25 },
    new Produto { Nome = "Kindle Paperwhite", Valor = 139.99, Quantidade = 30 },
    new Produto { Nome = "Sony PlayStation 5", Valor = 499.99, Quantidade = 18 }
};

//Endpoints - Funcionalidades
//Requisição - URL e método/verbo HTTP
// resposta- Dados (json/ xml) e codigo HTTP de status
//GET: /
app.MapGet("/", () => "API de Produtos");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    if (produtos.Count > 0)
    {

        return Results.Ok(produtos);

    }
    return Results.NotFound();
});

//POST: /api/produto/cadastrar/param_nome
app.MapPost("/api/produto/cadastrar", ([FromBody] Produto produto) =>
{
    produtos.Add(produto);
    return Results.Created(" ", produto);
});


app.Run();

//Exercícios para próxima aula
// - Criar um endpoint para receber informação pela URL
// - Criar um endpoint para receber informação pelo corpo

//Java
// Produto produto = new Produto();
// produto.setValor(10);
// Console.WriteLine("Preco: " + produto.getValor());

//C#
// Produto produto = new Produto();
// produto.Nome = "Notebook";
// Console.WriteLine("Preco: " + produto.Nome);