using IntegraBrasil.Core.Interfaces;
using IntegraBrasil.Core.Services;
using IntegraBrasil.Data.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
builder.Services.AddSingleton<IBancoServices, BancoServices>();
builder.Services.AddSingleton<IBrasilApiService, BrasilApiService>();
builder.Services.AddSingleton<IDDDService, DDDService>();

builder.Services.AddAutoMapper(typeof(EnderecoMapper));
builder.Services.AddAutoMapper(typeof(BancoMapper));
builder.Services.AddAutoMapper(typeof(DDDMapper));

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