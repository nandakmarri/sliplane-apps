var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/weather", () =>
{
    return new[] {
        new { Date = DateTime.Now, Temp = 25, Summary = "Sunny" }
    };
});

app.Run();
