using Super_Advanced_Super_Cool.Context;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Super_Advanced_Super_Cool.Repository;
using Super_Advanced_Super_Cool.Data;
using Super_Advanced_Super_Cool.Services;
using Super_Advanced_Super_Cool.Repository.Contracts;
using Super_Advanced_Super_Cool.Commands;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IAnimalClient, AnimalClient>();
builder.Services.AddTransient<AnimalService>();
builder.Services.AddDbContext<ApplicationContext>(opt =>
{
    opt.UseSqlServer("server=localhost;database=Workshop;User Id=app;Password=wally;TrustServerCertificate=true");
});
builder.Services.AddMudServices();
builder.Services.AddTransient<ITodoRepo, TodoRepo>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ITodoService, TodoService>();
builder.Services.AddTransient<ITodoItemCommands, TodoItemCommands>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
    
        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            context.Database.EnsureCreated();
        }
    

}
else
{
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
        context.Database.EnsureCreated();
       

    }
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days.
    // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
