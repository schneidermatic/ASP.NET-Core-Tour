var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "collection",
        pattern: "{controller=Collection}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "dictionary",
        pattern: "{controller=dictionary}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "patternmatching",
        pattern: "{controller=dictionary}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "extensionmethod",
        pattern: "{controller=dictionary}/{action=Index}/{id?}");

});

/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
*/

app.Run();
