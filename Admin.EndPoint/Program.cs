using Admin.EndPoint.MappingProfiles;
using Admin.EndPoint.ViewModels.Catalog;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Application.Banners;
using Project.Application.CatalogitemImage.GetCatalogItemIageSrcService;
using Project.Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Project.Application.Catalogs.CatalogItems.GetCatalogBrands;
using Project.Application.Catalogs.CatalogItems.GetCatalogItemList;
using Project.Application.Catalogs.CatalogItems.GetCatalogTypes;
using Project.Application.Catalogs.CatalogitemsList;
using Project.Application.Catalogs.CatalogTypes;
using Project.Application.Discount;
using Project.Application.Interfaces.DatabaseContext;
using Project.Application.Visistors.GetTodayReport;
using Project.Domain.User;
using Project.Infrastructure.ExternalApi.ImageService;
using Project.Infrastructure.IdentityConfigs;
using Project.Infrastructure.MappingProfile;
using Project.Persistence;
using Project.Persistence.Contexts.MongoContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers();


builder.Services.AddDbContext<IdentityDataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
});


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
builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/account/AccessDenied/";
    options.SlidingExpiration = true;
});


builder.Services.AddScoped<IGetTodayReportService, GetTodayReportService>();
builder.Services.AddTransient(typeof(IMongoDataBaseContext<>), typeof(MongoDbContext<>));
builder.Services.AddAutoMapper(typeof(CatalogMappingProfile));
builder.Services.AddAutoMapper(typeof(CatalogTypeVMProfile));
builder.Services.AddScoped<ICatalogTypeService, CatalogTypeService>();
builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();
builder.Services.AddScoped<IAddNewCatalogItem, AddNewCatalogItem>();
builder.Services.AddScoped<IGetCatalogBrands, GetCatalogBrands>();
builder.Services.AddScoped<IGetCatalogType, GetCatalogType>();
builder.Services.AddScoped<IUploadImageService, UploadImageService>();
builder.Services.AddScoped<IGetCatalogItemList, GetCatalogItemList>();
builder.Services.AddScoped<IDiscountServices, DiscountServices>();
builder.Services.AddScoped<ICatalogItemList, CatalogItemList>();
builder.Services.AddScoped<IDiscountHistoryService, DiscountHistoryService>();
builder.Services.AddScoped<IBannerServices, BannerServices>();
builder.Services.AddScoped<IGetCatalogItemImageSrc, GetCatalogItemImageSrc>();
//fluent validation

builder.Services.AddTransient<IValidator<AddNewCatalogItemDto>,AddNewCatalogItemDtoValidator>();

builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddDistributedSqlServerCache(options =>
{
    options.ConnectionString = builder.Configuration.GetConnectionString("SqlServer");
    options.SchemaName = "dbo";
    options.TableName = "tbl_cache";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
