using ETrade.Dal;
using ETrade.Dto;
using ETrade.Entity.Concretes;
using ETrade.Repos.Abstracts;
using ETrade.Repos.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TradeContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Baglanti")));
builder.Services.AddScoped<IBasketDetailRep, BasketDetailRep<BasketDetail>>();
builder.Services.AddScoped<IBasketMasterRep, BasketMasterRep<BasketMaster>>();
builder.Services.AddScoped<ICategoriesRep, CategoriesRep<Categories>>();
builder.Services.AddScoped<ICityRep, CityRep<City>>();
builder.Services.AddScoped<ICountyRep, CountyRep<County>>();
builder.Services.AddScoped<IProductsRep, ProductsRep<Products>>();
builder.Services.AddScoped<ISuppliersRep, SuppliersRep<Suppliers>>();
builder.Services.AddScoped<IUnitRep, UnitRep<Unit>>();
builder.Services.AddScoped<IUsersRep, UsersRep<Users>>();
builder.Services.AddScoped<IVatRep, VatRep<Vat>>();
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<CityModel>();
builder.Services.AddScoped<CategoriesModel>();
builder.Services.AddScoped<UnitModel>();
builder.Services.AddScoped<UsersModel>();
builder.Services.AddScoped<BasketMaster>();
builder.Services.AddScoped<BasketDetail>();
builder.Services.AddScoped<BasketDetailModel>();
builder.Services.AddScoped<List<ProductSDTO>>();
builder.Services.AddScoped<BasketDetailDTO>();
//builder.Services.AddScoped<List<County>>();
builder.Services.AddSession(x => x.IdleTimeout = TimeSpan.FromHours(5));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
