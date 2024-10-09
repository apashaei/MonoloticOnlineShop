using Microsoft.EntityFrameworkCore;
using Project.Persistence;
using Project.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Project.Domain.User;
using Project.Infrastructure.IdentityConfigs;
using Project.Application.Interfaces.DatabaseContext;
using Project.Persistence.Contexts.MongoContext;
using Project.Application.Visistors.SaveVisitorInfo;
using Project.EndPoint.Utilities.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using Admin.EndPoint.Hubs;
using Project.Application.Visistors.OnlineVisitor;
using Project.EndPoint.Utilities.MiddleWares;
using Project.Application.Catalogs.GetMenuItem;
using Project.Infrastructure.MappingProfile;
using Project.Application.Catalogs.CatalogItemListPLP;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Catalogs.CatalogItemPDP;
using Project.Application.BasketServices;
using Project.Application.BasketServices.AddCatalogItemToBasket;
using Project.Application.BasketServices.DeleteCatalogItemFromBasketService;
using Project.Application.BasketServices.SetQuntityService;
using Project.Application.UserServices;
using Project.Application.OrderServices;
using Project.Application.Payment;
using Project.Application.Discount;
using Project.Application.Catalogs.CatalogItems.GetCatalogItemFavorite;
using Project.Application.Catalogs.CatalogItems.GetCatalogBrands;
using Project.Application.HomePageInfo;
using Project.EndPoint.MiddleWares;
using MediatR;
using Project.Application.Catalogs.CatalogComments.Commands;
using System.Reflection;
using Project.Application.Catalogs.CatalogComments.Queries;
using Project.Application.Token;
using Project.Infrastructure.ExternalApi.SendToken;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
    // Register the custom action filter globally
    options.Filters.Add<SavaVisitorFilter>();
}).AddRazorRuntimeCompilation();

builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddDbContext<IdentityDataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));


builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityDataBaseContext>()
    .AddDefaultTokenProviders()
    .AddRoles<IdentityRole>()
    .AddErrorDescriber<CustomIdentityError>();

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
builder.Services.AddTransient(typeof(IMongoDataBaseContext<>),typeof(MongoDbContext<>));
builder.Services.AddTransient<ISaveVisitorInfoService, SaveVisitorInfoService>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(SendCommentCommand).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetCommentListQuery).GetTypeInfo().Assembly));



builder.Services.AddAuthorization();

builder.Services.AddDistributedSqlServerCache(options =>
{
    options.ConnectionString = builder.Configuration.GetConnectionString("SqlServer");
    options.SchemaName = "dbo";
    options.TableName = "tbl_cache";
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/account/AccessDenied/";
    options.SlidingExpiration = true;
});
builder.Services.AddScoped<SavaVisitorFilter>();
builder.Services.AddScoped<IVisitorOnlineService, VisitorOnlineService>();
builder.Services.AddSignalR();
builder.Services.AddScoped<IGetMenuItem,GetMenuItem>();
builder.Services.AddAutoMapper(typeof(CatalogMappingProfile));
builder.Services.AddAutoMapper(typeof(UserMappingProfile));
builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();
builder.Services.AddScoped<IIdentityDataBaseContext, IdentityDataBaseContext>();
builder.Services.AddScoped<ICatalogItemListPLPService, CatalogItemListPLPService>();
builder.Services.AddScoped<IGetCatalogItemImageSrc, GetCatalogItemImageSrc>();
builder.Services.AddScoped<ICatalogitemPDPService, CatalogitemPDPService>();
builder.Services.AddScoped<IBasketServices, BasketServices>();
builder.Services.AddScoped<IAddCatalogItemToBasketService, AddCatalogItemToBasketService>();
builder.Services.AddScoped<IDeleteItemFromBaseket, DeleteItemFromBaseket>();
builder.Services.AddScoped<ISetQuantityService, SetQuantityService>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IOrderServices, OrderServices>();
builder.Services.AddScoped<IPaymentServices, PaymentServices>();
builder.Services.AddScoped<IDiscountServices, DiscountServices>();
builder.Services.AddScoped<IDiscountHistoryService, DiscountHistoryService>();
builder.Services.AddScoped<IAddToMyFavorites, AddToMyFavorites>();
builder.Services.AddScoped<IGetFavoriteList, GetFavoriteList>();
builder.Services.AddScoped<IGetCatalogBrands, GetCatalogBrands>();
builder.Services.AddScoped<IHomePageInfoServices, HomePageInfoServices>();
builder.Services.AddScoped<ITokenServices, TokenServices>();
builder.Services.AddScoped<ISendToken, SendToken>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCustomExecption();
app.UseSetVisitorId();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "ProductDetail",
    pattern: "{product}/{Slug}",
    defaults: new {controller="product",action="details"}

    );

app.UseEndpoints(endpoints => endpoints.MapHub<OnLineVisitorHub>("/chatHub"));

app.Run();
