var builder = WebApplication.CreateBuilder(args);

// Agrega servicios MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura el pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Ruta por defecto: ClienteController -> Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cliente}/{action=Index}/{id?}");

app.Run();