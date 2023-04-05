using GreenMountain.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//MM NOTE: getting a warning about not needing the AddEntityFramework call - still need to play around with that.
//MM NOTE: used the wrong case convention, now everything is ALL CAPS :(
//MM NOTE: I'm wondering if we need the EFCore.Design package - need to look into what its doing with Migrations

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<GreenMountainContext>(opt => 
    opt.UseNpgsql(builder.Configuration.GetConnectionString("GreenMountainDb")).UseUpperSnakeCaseNamingConvention());

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
