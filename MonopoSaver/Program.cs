using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MongoDB.Driver;
using MonopoSaver.DataModels;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using MonopoSaver;
using Blazorise;
using Blazorise.Bootstrap;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddHttpClient();

builder.Services.AddBlazorise( options =>
    {
        options.Immediate = true;
    } 
).AddBootstrapProviders();

static void ConfigureMDBServices(IServiceCollection services)
{

    string MDBCONNSTR = Environment.GetEnvironmentVariable("MDBCONNSTR").Trim();
    var settings = MongoClientSettings.FromConnectionString(MDBCONNSTR);
    settings.ServerApi = new ServerApi(ServerApiVersion.V1);

    services.AddSingleton<IMongoClient>(new MongoClient(settings));
    services.AddSingleton<IMongoDatabase>(x => x.GetRequiredService<IMongoClient>().GetDatabase("monoposaver"));
    services.AddSingleton<IMongoCollection<Game>>(x => x.GetRequiredService<IMongoDatabase>().GetCollection<Game>("game"));
}

ConfigureMDBServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//app.MapBlazorHub();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
//app.MapFallbackToPage("/_Host");

app.UseAntiforgery();

app.Run();