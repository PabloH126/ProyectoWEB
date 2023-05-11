using Microsoft.EntityFrameworkCore;
using ProyectoBanco.Server.Data;
using ProyectoBanco.Server.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
    }
));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connString = builder.Configuration.GetConnectionString("BancoContext");
builder.Services.AddSqlServer<BancoContext> (connString);


var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var groupUsuario = app.MapGroup("/Usuarios")
               .WithParameterValidation();

//Get /Usuarios
groupUsuario.MapGet("/", async (BancoContext context) =>
                                            await context.Usuarios.AsNoTracking().ToListAsync()
);

//Get /Usuarios/{id}
groupUsuario.MapGet("/{id}", async (int id, BancoContext context) =>
{
    Usuario? user = await context.Usuarios.FindAsync(id);

    if(user is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(user);
}
)
.WithName("GetUsuario");

//Post /Usuarios
groupUsuario.MapPost("/", async (Usuario user, BancoContext context) =>
{
    context.Usuarios.Add(user);
    await context.SaveChangesAsync();
    return Results.CreatedAtRoute("GetUsuario", new {id = user.DetallesU }, user);
});

//Put /Usuarios/{id}
groupUsuario.MapPut("/{id}", async (int id, Usuario updatedUsuario, BancoContext context) =>
{
    var rowsAffected = await context.Usuarios.Where(
        user => user.DetallesU == id
    ).ExecuteUpdateAsync(updates =>
    updates.SetProperty(user => user.IdUsuario, updatedUsuario.IdUsuario)
           .SetProperty(user => user.DetallesU, updatedUsuario.DetallesU)
           .SetProperty(user => user.Cuenta, updatedUsuario.Cuenta));
});

//Delete /Usuarios/{id}
groupUsuario.MapDelete("/{id}", async (int id, BancoContext context) =>
{
    var rowsAffected = await context.Usuarios.Where(
        user => user.DetallesU == id
    ).ExecuteDeleteAsync();
    return rowsAffected == 0 ? Results.NotFound() : Results.NoContent();
});




var groupCuentum = app.MapGroup("/Usuarios")
               .WithParameterValidation();

//Get /Usuarios
groupCuentum.MapGet("/", async (BancoContext context) =>
                                            await context.Usuarios.AsNoTracking().ToListAsync()
);

//Get /Usuarios/{id}
groupCuentum.MapGet("/{id}", async (int id, BancoContext context) =>
{
    Usuario? user = await context.Usuarios.FindAsync(id);

    if(user is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(user);
}
)
.WithName("GetUsuario");

//Post /Usuarios
groupCuentum.MapPost("/", async (Usuario user, BancoContext context) =>
{
    context.Usuarios.Add(user);
    await context.SaveChangesAsync();
    return Results.CreatedAtRoute("GetUsuario", new {id = user.DetallesU }, user);
});

//Put /Usuarios/{id}
groupCuentum.MapPut("/{id}", async (int id, Usuario updatedUsuario, BancoContext context) =>
{
    var rowsAffected = await context.Usuarios.Where(
        user => user.DetallesU == id
    ).ExecuteUpdateAsync(updates =>
    updates.SetProperty(user => user.IdUsuario, updatedUsuario.IdUsuario)
           .SetProperty(user => user.DetallesU, updatedUsuario.DetallesU)
           .SetProperty(user => user.Cuenta, updatedUsuario.Cuenta));
});

//Delete /Usuarios/{id}
groupCuentum.MapDelete("/{id}", async (int id, BancoContext context) =>
{
    var rowsAffected = await context.Usuarios.Where(
        user => user.DetallesU == id
    ).ExecuteDeleteAsync();
    return rowsAffected == 0 ? Results.NotFound() : Results.NoContent();
});

app.Run();
