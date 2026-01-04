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
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

builder.Services.AddCors(options =>
{
    options.AddPolicy("NetlifyPolicy",
        policy =>
        {
            policy.WithOrigins("https://super-cannoli-8c7615.netlify.app") // הכתובת של Netlify
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors("NetlifyPolicy");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
