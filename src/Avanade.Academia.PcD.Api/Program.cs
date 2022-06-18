
//using Avanade.Academia.PcD.Infra.Database;
using Avanade.Academia.PcD.Application.Interfaces;
using Avanade.Academia.PcD.Application.Services;
using Avanade.Academia.PcD.Domain.Interfaces;
using Avanade.Academia.PcD.Domain.Repositories;
using Avanade.Academia.PcD.Infra.Database;
using Avanade.Academia.PcD.Infra.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProfessorAppService, ProfessorAppService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddDbContextFactory<ProjetoContext>();

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
