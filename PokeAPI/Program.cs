using Microsoft.EntityFrameworkCore;
using PokeApi.Application.Infra.Data.DBContext;
using PokeAPI.Extension;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddRepository();
builder.Services.AddControllers(
options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
builder.Services.AddControllers(x => x.AllowEmptyInputInBodyModelBinding = true);

builder.Services.AddDbContext<PokeApiDbContext>(options =>
{
    var cnn = builder.Configuration.GetConnectionString("PokeApiDB");
    options.UseSqlServer(cnn);
});



var app = builder.Build();

app.UseCors(m => m.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

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
