using FitnessPlanner.Services;
using FitnessPlanner.Services.interfaces;
using FitnessPlannerRepository;
using FitnessPlannerRepository.Repository;
using FitnessPlannerRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FitnessPlannerDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FitnessPlannerDBContext") ?? throw new InvalidOperationException("Connection string 'FitnessPlannerDBContext' not found.")));


builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IModuleRepository, ModuleRepository>();
builder.Services.AddScoped<ICalendarRepository, CalendarRepository>();
builder.Services.AddScoped(typeof(IBaseControllerService<,>), typeof(BaseControllerService<,>));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var corsPolicyName = "Angular FrontEnd";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicyName,
                      policy =>
                      {
                          policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(corsPolicyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
