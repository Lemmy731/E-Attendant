using Attendee.Application.Implement;
using Attendee.Application.Interface;
using Infrastruture.Context.Infrastructure;
using Infrastruture.Context.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyDbContext>(Options => { Options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnections")); });
builder.Services.AddScoped<IService, Service>();
builder.Services.AddScoped<IAttendeeRepo, AttandeeRepo>();

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
    pattern: "{controller=Attendance}/{action=Index}/{id?}");

app.Run();
