using API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Catalogs.CatalogComments.Commands;
using Project.Application.Catalogs.CatalogComments.Queries;
using Project.Application.Catalogs.CatalogItemListPLP;
using Project.Application.Catalogs.CatalogItemPDP;
using Project.Application.Catalogs.CatalogItems.GetCatalogItemFavorite;
using Project.Application.Interfaces.DatabaseContext;
using Project.Application.Token;
using Project.Application.UserServices;
using Project.Domain.User;
using Project.Infrastructure.ExternalApi.SendToken;
using Project.Persistence;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var jwtConfig = builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>();
var key = Encoding.ASCII.GetBytes(jwtConfig.Key);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityDataBaseContext>()
    .AddDefaultTokenProviders()
    .AddRoles<IdentityRole>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.User.RequireUniqueEmail = true;


    options.Password.RequiredUniqueChars = 1;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.User.RequireUniqueEmail = true;
    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);

});


builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddDbContext<IdentityDataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));

builder.Services.AddAuthentication(options =>
{
    options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidIssuer = jwtConfig.Issuer,
        ValidAudience = jwtConfig.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
    };
    options.SaveToken = true;// HttpContext.GetTokenAsync()
    options.Events = new JwtBearerEvents
    {
        OnAuthenticationFailed = context =>
        {
            return Task.CompletedTask;
        },
        OnTokenValidated = context =>
        {
            // calidate اختصاصی
            return Task.CompletedTask;
        },
        OnChallenge = cobtext =>
        {
            return Task.CompletedTask;
        },
        OnMessageReceived = context =>
        {
            return Task.CompletedTask;
        },
        OnForbidden = context =>
        {
            return Task.CompletedTask;
        }

    };
});



builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(SendCommentCommand).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetCommentListQuery).GetTypeInfo().Assembly));

builder.Services.AddScoped<ICatalogitemPDPService, CatalogitemPDPService>();
builder.Services.AddScoped<ICatalogItemListPLPService, CatalogItemListPLPService>();

builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();
builder.Services.AddScoped<IIdentityDataBaseContext, IdentityDataBaseContext>();
builder.Services.AddScoped<IGetCatalogItemImageSrc, GetCatalogItemImageSrc>();
builder.Services.AddScoped<IAddToMyFavorites, AddToMyFavorites>();
builder.Services.AddScoped<IGetFavoriteList, GetFavoriteList>();
builder.Services.AddScoped<ISendToken, SendToken>();
builder.Services.AddScoped<ITokenServices, TokenServices>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
