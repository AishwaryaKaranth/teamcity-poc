var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Testing TeamCity .NET deployment. Trigger build again!");

app.Run();
