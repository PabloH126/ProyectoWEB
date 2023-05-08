using Microsoft.EntityFrameworkCore;
using ProyectoBanco.Server.Models;
using System.Reflection;

namespace ProyectoBanco.Server.Data;

public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
    }
    public DbSet<Cuentum> Cuenta => Set<Cuentum>();
    public DbSet<Dato> Datos => Set<Dato>();
    public DbSet<DetallesCuentum> DetallesCuenta => Set<DetallesCuentum>();
    public DbSet<DetallesEmpleado> DetallesEmpleados => Set<DetallesEmpleado>();
    public DbSet<DetallesGerente> DetallesGerentes => Set<DetallesGerente>();
    public DbSet<DetallesHistorial> DetallesHistorials => Set<DetallesHistorial>();
    public DbSet<DetallesPrestamo> DetallesPrestamos => Set<DetallesPrestamo>();
    public DbSet<DetallesUsuario> DetallesUsuarios => Set<DetallesUsuario>();
    public DbSet<Empleado> Empleados => Set<Empleado>();
    public DbSet<Gerente> Gerentes => Set<Gerente>();
    public DbSet<Historial> Historials => Set<Historial>();
    public DbSet<IdProvider> IdProviders => Set<IdProvider>();
    public DbSet<Nomina> Nominas => Set<Nomina>();
    public DbSet<Prestamo> Prestamos => Set<Prestamo>();
    public DbSet<Rifa> Rifas => Set<Rifa>();
    public DbSet<Solicitud> Solicituds => Set<Solicitud>();
    public DbSet<Usuario> Usuarios => Set<Usuario>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
