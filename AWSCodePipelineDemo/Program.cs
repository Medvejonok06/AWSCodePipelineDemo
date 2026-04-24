var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Ми ПРИБРАЛИ app.UseHttpsRedirection(); — саме він вбивав деплой!

app.UseAuthorization();
app.MapControllers();

// Наш ендпоінт для перевірки
app.MapGet("/", () => "Hello World v2!");

app.Run();