using ETicaret.Model;
using ETicaret.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer("Data Source =DESKTOP-7HODA89\\SQLEXPRESS; Initial Catalog=ETicaretDb; Integrated Security=true; TrustServerCertificate=True"));
builder.Services.AddScoped<KategoriRepository, KategoriRepository>();
builder.Services.AddScoped<RolRepository, RolRepository>();
builder.Services.AddScoped<KullaniciRepository, KullaniciRepository>();



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
