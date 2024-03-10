using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoUniversity.DAL;


using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static int[] IndexOfCapitals(string str)
    {
        for (int i = 1; i < str.length(); i++)
    }
}


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContosoSchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContosoSchoolContext") ?? throw new InvalidOperationException("Connection string 'ContosoSchoolContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Run();

