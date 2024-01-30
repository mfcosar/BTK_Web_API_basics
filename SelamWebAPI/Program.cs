var builder = WebApplication.CreateBuilder(args);


//app.MapGet("/", () => "Selamun aleykum!");

//Service(Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders(); // IoC'e kay�t yapmaya gerek yok ��nk� .net framework bize default olarak Loggin mekanizmas� veriliyor
builder.Logging.AddConsole();
builder.Logging.AddDebug();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); //servis kayd� var ama kullanmas� gerekti�ini de s�ylemek gerek
    app.UseSwaggerUI();
}


app.MapControllers();
app.Run();
