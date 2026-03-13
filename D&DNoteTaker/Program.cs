using D_DNoteTaker.Components;
using D_DNoteTaker.Components.Models;
using D_DNoteTaker.Components.Objects;
using D_DNoteTaker.Data;
using D_DNoteTaker.Data.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using AspNetCore.Identity.Mongo;
//using AspNetCore.Identity.Mongo.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAntiforgery();

builder.Services.AddScoped<IMongoRepository<Testing>>((sp) => {
    var client = new MongoClient("mongodb+srv://default:password123!@user.xummolz.mongodb.net/?appName=User");
    var database = client.GetDatabase("Testing");
    MongoRepository<Testing> test = new MongoRepository<Testing>(database, "Testing");
    return test; 
    });

builder.Services.AddScoped<IMongoRepository<Campaign>>((sp) => {
    var client = new MongoClient("mongodb+srv://default:password123!@user.xummolz.mongodb.net/?appName=User");
    var database = client.GetDatabase("Campaign");
    MongoRepository<Campaign> campaignData = new MongoRepository<Campaign>(database, "Campaign");
    return campaignData;
});

builder.Services.AddScoped<IMongoRepository<Location>>((sp) => {
    var client = new MongoClient("mongodb+srv://default:password123!@user.xummolz.mongodb.net/?appName=User");
    var database = client.GetDatabase("Campaign");
    MongoRepository<Location> locationData = new MongoRepository<Location>(database, "Location");
    return locationData;
});

builder.Services.AddScoped<IMongoRepository<NPCs>>((sp) => {
    var client = new MongoClient("mongodb+srv://default:password123!@user.xummolz.mongodb.net/?appName=User");
    var database = client.GetDatabase("Campaign");
    MongoRepository<NPCs> npcData = new MongoRepository<NPCs>(database, "NPCs");
    return npcData;
});

builder.Services.AddScoped<IMongoRepository<Region>>((sp) => {
    var client = new MongoClient("mongodb+srv://default:password123!@user.xummolz.mongodb.net/?appName=User");
    var database = client.GetDatabase("Campaign");
    MongoRepository<Region> regionData = new MongoRepository<Region>(database, "Region");
    return regionData;
});

builder.Services.AddScoped<IMongoRepository<Sessions>>((sp) => {
    var client = new MongoClient("mongodb+srv://default:password123!@user.xummolz.mongodb.net/?appName=User");
    var database = client.GetDatabase("Campaign");
    MongoRepository<Sessions> sessionData = new MongoRepository<Sessions>(database, "Sessions");
    return sessionData;
});

builder.Services.AddScoped<IMongoRepository<Worldbuilding>>((sp) => {
    var client = new MongoClient("mongodb+srv://default:password123!@user.xummolz.mongodb.net/?appName=User");
    var database = client.GetDatabase("Campaign");
    MongoRepository<Worldbuilding> worldbuildingData = new MongoRepository<Worldbuilding>(database, "Worldbuilding");
    return worldbuildingData;
});

builder.Services.AddIdentityMongoDbProvider<User>(
    identity =>
    {
        identity.SignIn.RequireConfirmedAccount = false;
        identity.SignIn.RequireConfirmedEmail = false;
        identity.SignIn.RequireConfirmedPhoneNumber = false;
    },
    mongo =>
    {
        mongo.ConnectionString = "mongodb+srv://default:password123!@user.xummolz.mongodb.net/Campaign?appName=User";
    });

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorization();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
