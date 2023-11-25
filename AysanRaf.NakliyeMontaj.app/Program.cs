using AysanRaf.NakliyeMontaj.app.Models;
using AysanRaf.NakliyeMontaj.Business.Mapping;
using AysanRaf.NakliyeMontaj.Business.Services;
using AysanRaf.NakliyeMontaj.DataAccess.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAutoMapper(typeof(MapProfile));


builder.Services.AddScoped<IBaseService<ShippingInstallationCustomer>, BaseService<ShippingInstallationCustomer>>();
builder.Services.AddScoped<IBaseRepository<ShippingInstallationCustomer>, BaseRepository<ShippingInstallationCustomer>>();

builder.Services.AddScoped<IBaseRepository<RentedEquipment>, BaseRepository<RentedEquipment>>();
builder.Services.AddScoped<IBaseService<RentedEquipment>, BaseService<RentedEquipment>>();


builder.Services.AddScoped<IBaseRepository<PlannedOfferForm>, BaseRepository<PlannedOfferForm>>();
builder.Services.AddScoped<IBaseService<PlannedOfferForm>, BaseService<PlannedOfferForm>>();

builder.Services.AddScoped<IBaseRepository<RealizedOfferForm>, BaseRepository<RealizedOfferForm>>();
builder.Services.AddScoped<IBaseService<RealizedOfferForm>, BaseService<RealizedOfferForm>>();




builder.Services.AddDbContext<aysanrafpopsepdevelopment_2023_09_10_05_45Context>();


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