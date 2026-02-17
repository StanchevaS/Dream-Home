using DreamHome.Data;
using DreamHome.Infrastructure.Data.Models.Roles;
using DreamHome.Infrastructure.Data.Models.User;
using DreamHome.Infrastructure.Repositories;
using DreamHome.Infrastructure.Repositories.Contracts;
using DreamHome.MapperProfiles;
using DreamHome.Services.BookingServices;
using DreamHome.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<DreamHomeUser>(options => options.SignIn.RequireConfirmedAccount = false)
    // .AddRoles<DreamHomeAdminRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
  
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/User/Login";
    options.AccessDeniedPath = "/Home/Index";
});

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<BookingMapperProfile>();
});

builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// app.UseHttpsRedirection();
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

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapDefaultControllerRoute();

    endpoints.MapRazorPages();
});

app.Run();
