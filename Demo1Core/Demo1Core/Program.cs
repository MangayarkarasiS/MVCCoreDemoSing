
//console application - will be converted into we application
/*
 1. run to the server
2. listen to request
3. Main method is not visible her
4. it uses top level statements which is a new feature of c# 9.0
5. builder - taking care of configurations even at runtime, it uses kestrel server,
             dependency injection, pipelines 
 */

/*vs 2019
 startup.cs - configureservices(), configure()
  configureservices() - register all classes or services here
  configure() - pipeline request will be given 
 
replaced by program.cs file in vs2022
 */

using Demo1Core.Models;

var builder = WebApplication.CreateBuilder(args);//createbuilder - internal server kestrel

// Add services to the container.

builder.Services.AddControllersWithViews();// this method will add MVC folder into our application
builder.Services.AddSingleton<IEmp, MockEmp>();


var app = builder.Build();// executing the application

// 3 types of environment - development, staging, production
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
