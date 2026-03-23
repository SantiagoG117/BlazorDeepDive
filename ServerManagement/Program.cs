using Microsoft.EntityFrameworkCore;
using ServerManagement.Components;
using ServerManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container (Dependency Injection).
builder.Services.AddDbContextFactory<ServerManagerContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerManagement"));
});
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<ServerManagement.State.ServerStateObserver>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();


app.MapStaticAssets();

/*
    Maps the HTTP request to the a particular component. In this case, it will map to the App component
    which is the root component of the application. The App component is responsible for rendering the layout of the 
    application and also for rendering the child components based on the URL.

    The root component takes care of all the incoming HTTP requests and then it will decide which component to render based on the URL. 
    For example, if the URL is '/' then it will render the Home component, if the URL is '/about' then it will render the About component and so on. 
 */
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

/*
    app.Run() runs in a loop listening to incoming HTTP requests. When a new HTTP request
    comes into the application it will be pickup and then it will run all the lines after
    var app = builder.Build();  
 */
app.Run();
