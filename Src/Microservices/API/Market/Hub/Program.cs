using Common.Application.DependencyInjection;
using Common.Identity.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.AddAuth();
builder.AddSwagger();

var app = builder.Build();

app.UseSwaggerDev();
app.UseHttpsRedirection();
app.UseAuth();
app.MapControllers();

app.Run();
