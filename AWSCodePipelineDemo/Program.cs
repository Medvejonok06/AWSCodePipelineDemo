var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // ЗМІНЕНО ТУТ

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // ЗМІНЕНО ТУТ
    app.UseSwaggerUI(); // ЗМІНЕНО ТУТ
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Наш тестовий ендпоінт
app.MapGet("/", () => "Hello World! .NET 8 on Debian");

app.Run();