using D_DNoteTaker.Components;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



#region MongoDB Database Demo
var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
//var connectionString = "mongodb+srv://32tiptoes:14Foxgames@user.xummolz.mongodb.net/?appName=User";
if (connectionString == null)
{
    Console.WriteLine("You must set your 'MONGODB_URI' environment variable. To learn how to set it, see https://www.mongodb.com/docs/drivers/csharp/current/get-started/create-connection-string");
    Environment.Exit(0);
}
var client = new MongoClient(connectionString);
var collection = client.GetDatabase("sample_mflix").GetCollection<BsonDocument>("movies");
var filter = Builders<BsonDocument>.Filter.Eq("title", "Back to the Future");
var document = collection.Find(filter).First();
Console.WriteLine(document.ToJson(new JsonWriterSettings { Indent = true }));
#endregion

app.Run();
