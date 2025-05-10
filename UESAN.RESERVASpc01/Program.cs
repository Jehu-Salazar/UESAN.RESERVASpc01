using Microsoft.EntityFrameworkCore;
using UESAN.RESERVASpc01.CORE.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add DbContext configuration
builder.Services.AddDbContext<ReservaDeCanchaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure OpenAPI (Swagger)
builder.Services.AddOpenApi();

// Register other services like your repositories or services
// builder.Services.AddScoped<ICanchaService, CanchaService>();
// builder.Services.AddScoped<ICanchaRepository, CanchaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
