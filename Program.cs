using CommonService;
using BussinessLayer;
using CommonService.DatabaseLayer.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using User.Management.Service.Data_Access_Layer__DAL_.Context;
using User.Management.Service.Data_Access_Layer__DAL_.Models;
using E_Commerce_Project.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Add Service To COntainer In Data Access Layer (DAL)

builder.Services.AddSqlServerDataBase<Context>(builder.Configuration);
builder.Services.AddIdentityandDependancies<Context, UserModel, IdentityRole>(builder.Configuration);
#endregion



#region  Bussines Layer Services Injection

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();


builder.Services.AddTransient<DbContext, Context>();

builder.Services.AddTransient<IEntityRepositorystringId<UserModel>, EntityRepositorystringId<UserModel>>();
builder.Services.AddTransient<IEntityRepositoryIntId<CategoryModel>, EntityRepositoryIntId<CategoryModel>>();
builder.Services.AddTransient<IproductRepository<ProductModel>, ProductRepository<ProductModel>>();

#endregion



builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

builder.Services.Configure<IdentityOptions>(options =>
{
    // Other Identity settings

    // Disable the requirement for at least one uppercase letter
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
});


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

app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
