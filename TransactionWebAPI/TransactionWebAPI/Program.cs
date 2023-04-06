using Microsoft.EntityFrameworkCore;
using TransactionWebAPI.Core.Implimentations;
using TransactionWebAPI.Core.Interfaces;
using TransactionWebAPI.Infrastructure;
using TransactionWebAPI.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//config DBContext to SqlServer
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//services and repository injection
builder.Services.AddScoped<IMerchantRepository, MerchantRepository>();
builder.Services.AddScoped<IMerchantService, MerchantService>();
builder.Services.AddScoped<IPaymentTerminalRepository, PaymentTerminalRepository>();
builder.Services.AddScoped<IPaymentTerminalService, PaymentTerminalService>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

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

//seeding of data
//AppDbInitializer.Seed(app);

app.Run();
