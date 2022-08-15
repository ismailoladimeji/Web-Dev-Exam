
using Microsoft.EntityFrameworkCore;
using mySmartWallet2022.Models.Data;
using mySmartWallet2022.Models.Data.Entities;
using mySmartWallet2022.Models.Data.Interface;
using mySmartWallet2022.Models.Data.Reposiory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<ApplicationDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("BusinessConnection")));
builder.Services.AddDbContext<ApplicationDbContext>(c => c.UseSqlServer("server= DESKTOP-LV6BQJH ; database=mySmartWallet2Db; Trusted_Connection=True;"));

//builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IRepository<Customer,Guid> , Repository<Customer, Guid>>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

var serviceProvider = app.Services.GetRequiredService<IServiceProvider>();
using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

   await SeedHelperClass.seed(context);
}
app.Run();
