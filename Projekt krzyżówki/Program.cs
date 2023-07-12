using Microsoft.EntityFrameworkCore;
using Projekt_krzy¿ówki.Data;
using Projekt_krzy¿ówki.Interfaces;
using Projekt_krzy¿ówki.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IKrzyzowkiRepository, KrzyzowkiRepository>();
builder.Services.AddScoped<IPytaniaRepository, PytaniaRepository>();
// Add services to the container.
builder.Services.AddScoped<IUzytkownicyRepository, UzytkownikRepository>();
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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



app.Run();
