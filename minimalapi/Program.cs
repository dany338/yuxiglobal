var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/", () => "Hello World!");

app.MapGet("/hello/{name}", (string name) => $"Hello {name}!");

app.MapDelete("/hello/{name}", (string name) => $"Hello {name}!");

app.Run();
