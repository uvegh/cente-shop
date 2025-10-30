

var builder = WebApplication.CreateBuilder(args);

//add services 
builder.Services.AddCatalogModule(builder.Configuration);
builder.Services.AddBasketModule(builder.Configuration);
builder.Services.AddOrderModule(builder.Configuration);


var app = builder.Build();
//configure http request
app.UseCatalogModule().
    UseBasketModule().
    UseOrderModule();


app.Run();
 