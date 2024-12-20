using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql.Internal;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


string connectionString = builder.Configuration.GetConnectionString("MySQL");
ServerVersion serverVersion = new MySqlServerVersion("8.0.40");

builder.Services.AddDbContext<SocSitDbContext>(options =>
    options.UseMySql(connectionString, serverVersion,
        mysqlOptions => mysqlOptions.MigrationsAssembly("UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure")));

// Configuration for Identity
builder.Services.AddIdentity<User, Role>()
     .AddEntityFrameworkStores<SocSitDbContext>()
     .AddDefaultTokenProviders();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=User}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Intro}/{action=Index}/{id?}");

app.Run();
