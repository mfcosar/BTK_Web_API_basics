var builder = WebApplication.CreateBuilder(args);


//app.MapGet("/", () => "Selamun aleykum!");

//Service(Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders(); // IoC'e kayýt yapmaya gerek yok çünkü .net framework bize default olarak Loggin mekanizmasý veriliyor
builder.Logging.AddConsole();
builder.Logging.AddDebug();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); //servis kaydý var ama kullanmasý gerektiðini de söylemek gerek
    app.UseSwaggerUI();
}


app.MapControllers();
app.Run();
