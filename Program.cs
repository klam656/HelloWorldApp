var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // Enables serving CSS and other static files

app.MapGet("/", async context =>
{
    var html = await File.ReadAllTextAsync("wwwroot/index.html");
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(html);
});

app.Run();
