using MicrosAccounting.Api.Brokers.DateTimeBrokers;
using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Services.Foundations;
using MicrosAccounting.Api.Services.Foundations.Categories;
using MicrosAccounting.Api.Services.Foundations.Transactions;
using MicrosAccounting.Api.Services.Foundations.Users;
using MicrosAccounting.Api.Services.Transactions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// dbContext
builder.Services.AddDbContext<StorageBroker>();

// lifecycle
// brokers
builder.Services.AddTransient<IStorageBroker, StorageBroker>();
builder.Services.AddTransient<IDateTimeBroker, DateTimeBroker>();

// services
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ITransactionService, TransactionService>();


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();


app.Run();