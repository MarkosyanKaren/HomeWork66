using HomeWork66.BLL.Interfaces;
using HomeWork66.BLL.Services;
using HomeWork66.DAL;
using HomeWork66.DAL.Interfaces;
using HomeWork66.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolDBContext>();

builder.Services.AddTransient<IStaffRepo, StaffRepo>();
builder.Services.AddTransient<IStudentRepo, StudentRepo>();
builder.Services.AddTransient<IPropertyRepo, PropertyRepo>();

builder.Services.AddTransient<IStaffService, StaffService>();
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IPropertyService, PropertyService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
