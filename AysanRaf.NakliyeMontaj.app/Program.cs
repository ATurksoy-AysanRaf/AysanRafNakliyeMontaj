
using AysanRaf.NakliyeMontaj.app.Controllers;
using AysanRaf.NakliyeMontaj.Business.Mapping;
using AysanRaf.NakliyeMontaj.Business.Services;
using AysanRaf.NakliyeMontaj.DataAccess.Repositories;
using AysanRaf.NakliyeMontaj.Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using OfficeOpenXml;
using System.ComponentModel;
using LicenseContext = OfficeOpenXml.LicenseContext;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ExcelExportService>();
builder.Services.AddScoped<RealizedExcellExportService>();
builder.Services.AddScoped<PlannedRealizedComparisonExcellService>();



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod()
    );
});
//CORS


builder.Services.AddAutoMapper(typeof(MapProfile));




builder.Services.AddScoped<IBaseRepository<RentedEquipment>, BaseRepository<RentedEquipment>>();
builder.Services.AddScoped<IBaseService<RentedEquipment>, BaseService<RentedEquipment>>();


builder.Services.AddScoped<IBaseRepository<PlannedOfferForm>, BaseRepository<PlannedOfferForm>>();
builder.Services.AddScoped<IBaseService<PlannedOfferForm>, BaseService<PlannedOfferForm>>();

builder.Services.AddScoped<IBaseRepository<RealizedOfferForm>, BaseRepository<RealizedOfferForm>>();
builder.Services.AddScoped<IBaseService<RealizedOfferForm>, BaseService<RealizedOfferForm>>();


var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();


//builder.Services.AddDbContext<AysanRafContext>();

builder.Services.AddDbContext<AysanRafContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");////CORS

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();