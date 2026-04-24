var builder = WebApplication.CreateBuilder(args);

// ПРИМУСОВО вказуємо порт 5000, щоб AWS Elastic Beanstalk був задоволений
builder.WebHost.UseUrls("http://*:5000");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Вмикаємо Swagger для всіх середовищ (корисно для перевірки)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Наш головний тестовий ендпоінт
app.MapGet("/", () => "Hello World! .NET 8 on Debian");

app.Run();