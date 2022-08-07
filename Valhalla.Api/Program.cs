using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Valhalla.Application;
using Valhalla.Application.Interfaces;
using Valhalla.Application.Services;
using Valhalla.Domain.Interfaces;
using Valhalla.Infrastructure.Persistence;
using Valhalla.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "*",
        ValidAudience = "*",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("v1d1g17dghf56g4d6gfd84gdd56fg4dfgddfg8"))
    };
});
builder.Services.AddApplicationServices();
builder.Services.AddFluentValidation();
builder.Services.AddDbContext<ValhallaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Valhalla")));

//Repositories
//Brand
builder.Services.AddTransient<IBrandRepository, BrandRepository>();
//Favorite
builder.Services.AddTransient<IFavoriteRepository, FavoriteRepository>();
//Order
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
//Urus
builder.Services.AddTransient<IUrusRepository, UrusRepository>();
//User
builder.Services.AddTransient<IUserRepository, UserRepository>();
//VehicleColor
builder.Services.AddTransient<IVehicleColorRepository, VehicleColorRepository>();
//Vehicle
builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();

//Services
//Brand
builder.Services.AddTransient<IBrandService, BrandService>();
//Favorite
builder.Services.AddTransient<IFavoriteService, FavoriteService>();
//Order
builder.Services.AddTransient<IOrderService, OrderService>();
//Urus
builder.Services.AddTransient<IUrusService, UrusService>();
//User
builder.Services.AddTransient<IUserService, UserService>();
//VehicleColor
builder.Services.AddTransient<IVehicleColorService, VehicleColorService>();
//Vehicle
builder.Services.AddTransient<IVehicleService, VehicleService>();

builder.Services.AddCors(p => p.AddPolicy("ValhallaCors", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ValhallaCors");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
