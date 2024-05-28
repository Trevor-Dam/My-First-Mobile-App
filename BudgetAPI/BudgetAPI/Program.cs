var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/api/login", (HttpContext httpContext) =>
{
    var username = httpContext.Request.Form["username"];
    var password = httpContext.Request.Form["password"];
    if (username == "admin" && password == "admin")
    {
        httpContext.Response.StatusCode = 200;
        httpContext.Response.WriteAsync("Login successful");
    }
    else
    {
        httpContext.Response.StatusCode = 401;
        httpContext.Response.WriteAsync("Invalid username or password");
    }
});



app.Run();


