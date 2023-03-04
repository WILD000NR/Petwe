var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
