using EVS.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddControllers();
builder.AddDatabase();
builder.AddSwagger();
builder.AddServices();

var app = builder.Build();

app.AddSwagger();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
