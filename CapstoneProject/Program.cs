using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CapstoneProject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CapstoneProjectDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CapstoneProjectDbContext") ?? throw new InvalidOperationException("Connection string 'CapstoneProjectDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
