using AppWebSistemaClinica.C1Model.C1ModelContext;
using AppWebSistemaClinica.C3BusinessLogic;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

//Conexion
//builder.Services.AddDbContext<C1ModelContextContexto>(options => 
//options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
// Configure services and add DbContext
builder.Services.AddDbContext<C1ModelContextContexto>(options =>
{
    var configuration = builder.Configuration.GetSection("ConnectionStrings");
    var connectionString = configuration.GetConnectionString("MyConnectionString");
    options.UseSqlServer(connectionString);
});

// Inicializacion de inyeccion de dependencia 
builder.Services.AddScoped<C3BusinessLogicUsuario>();
builder.Services.AddScoped<C3BusinessLogicRol>();
builder.Services.AddScoped<C3BusinessLogicPerfil>();
builder.Services.AddScoped<C3BusinessLogicDetalleFactura>();
builder.Services.AddScoped<C3BusinessLogicFactura>();
builder.Services.AddScoped<C3BusinessLogicCita>();
builder.Services.AddScoped<C3BusinessLogicClinica>();
builder.Services.AddScoped<C3BusinessLogicEquipoMedico>();
builder.Services.AddScoped<C3BusinessLogicEspecialidad>();
builder.Services.AddScoped<C3BusinessLogicMedico>();
builder.Services.AddScoped<C3BusinessLogicPago>();



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
