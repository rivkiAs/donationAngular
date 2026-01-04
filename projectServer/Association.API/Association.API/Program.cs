using Association.Core.IRepositories;
using Association.Core.IServices;
using Association.Data;
using Association.Data.Repositories;
using Association.Service.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(
    options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.WriteIndented = true;
    }
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddScoped<ICitiesRepository, CitiesRepository>();
builder.Services.AddScoped<ICitiesService, CitiesService>();
builder.Services.AddScoped<IDonorRepository, DonorRepository>();
builder.Services.AddScoped<IDonorService, DonorService>();
builder.Services.AddScoped<IDonationRepository, DonationRepository>();
builder.Services.AddScoped<IDonationService, DonationService>();
builder.Services.AddScoped<IDonationTypeRepository, DonationTypeRepository>();
builder.Services.AddScoped<IDonationTypeService, DonationTypeService>();
builder.Services.AddScoped<IKerenRepository, kerenRepository>();
builder.Services.AddScoped<IKerenService, KerenService>();

builder.Services.AddDbContext<DataContext>();

// הגדרת CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("NetlifyPolicy",
        policy =>
        {
            policy.WithOrigins("https://super-cannoli-8c7615.netlify.app")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// חשוב: הפעלת ה-CORS חייבת לבוא לפני ה-MapControllers
app.UseCors("NetlifyPolicy");

// הצגת Swagger גם ב-Production (ב-Render) כדי שתוכלי לבדוק שהשרת עובד
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
