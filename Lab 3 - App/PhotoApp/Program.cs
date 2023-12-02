using Data;
using PhotoApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using PhotoApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();                         // dodać
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddTransient<IPhotoService, EFPhotoService>();
builder.Services.AddTransient<IAuthorService, EFAuthorService>();
builder.Services.AddMemoryCache();                        // dodać
builder.Services.AddSession();                            // dodać    

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

app.UseAuthentication();                                 // dodać
app.UseAuthorization();                                  // dodać
app.UseSession();                                        // dodać 
app.MapRazorPages();                                     // dodać

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Photo}/{action=Gallery}/{id?}");

app.Run();