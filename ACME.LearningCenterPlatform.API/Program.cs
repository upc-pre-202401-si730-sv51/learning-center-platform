using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add Database Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configure Database Context and Logging Levels

/*
 builder.Services.AddDbContext<AppDbContext>(options =>
 {
    if(connectionString != null)
      if (builder.Environment.IsDevelopment())
      options.UseMySQL(connectionString)
      .LogTo(Console.WriteLine, LogLevel.Information);
      .EnableSensitiveDataLogging()
      .EnableDetailedErrors();
      else if (builder.Environment.IsProduction())
        options.UseMySQL(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Error);
        .EnableDetailedErrors();       
 }); 
 */

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
         Title   = "ACME.LearningCenterPlatform.API",
         Version = "v1",
         Description = "ACME Learning Center Platform API",
         TermsOfService = new Uri("https://acme-learning.com/tos"),
         Contact = new OpenApiContact{ Name = "ACME Learning Center", Email = "contact@acme.com" },
         License = new OpenApiLicense { Name = "Apache 2.0", Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0.html")},
        });
    });

// Configure Lowercase URLs
builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

/*
 // Verify Database Objects are Created
 using (var scope = app.Services.CreateScope())
 {
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
 }
 */

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();