using Microsoft.EntityFrameworkCore;
using FitnessPlannerRepository;
using FitnessPlannerRepository.Repository;
using FitnessPlannerRepository.Repository.Interfaces;
using FitnessPlannerRepository.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FitnessPlannerDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FitnessPlannerDBContext") ?? throw new InvalidOperationException("Connection string 'FitnessPlannerDBContext' not found.")));

builder.Services.AddScoped<IRepository<ModuleEntity>, ModuleRepository>();
builder.Services.AddScoped<IRepository<CalendarEntity>, CalendarRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
