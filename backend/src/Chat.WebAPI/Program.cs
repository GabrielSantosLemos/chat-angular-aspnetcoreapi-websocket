WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(opcoes => opcoes.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
app.UseWebSockets();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
