var builder = WebApplication.CreateBuilder(args);

// ...

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(policyBuilder => policyBuilder.AddDefaultPolicy(policy => policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configuración de archivos estáticos
app.UseStaticFiles();

app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.Run();
