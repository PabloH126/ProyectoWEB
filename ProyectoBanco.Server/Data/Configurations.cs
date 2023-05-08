using ProyectoBanco.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoBanco.Server.Data;

public class CuentumConfiguration : IEntityTypeConfiguration<Cuentum>
{
    public void Configure(EntityTypeBuilder<Cuentum> builder)
    {
        builder.Property(cuentum => cuentum.NumCuenta)
        .HasPrecision(11);
        builder.Property(cuentum => cuentum.Contraseña)
        .HasMaxLength(10);
    }
}
public class DatoConfiguration : IEntityTypeConfiguration<Dato>
{
    public void Configure(EntityTypeBuilder<Dato> builder)
    {
        builder.Property(dato => dato.IdDatos)
        .HasPrecision(11);
        builder.Property(dato => dato.Nombres)
        .HasMaxLength(30);
        builder.Property(dato => dato.ApellidoP)
        .HasMaxLength(20);
        builder.Property(dato => dato.ApellidoM)
        .HasMaxLength(20);
        builder.Property(dato => dato.Dia)
        .HasMaxLength(2);
        builder.Property(dato => dato.Mes)
        .HasMaxLength(2);
        builder.Property(dato => dato.Año)
        .HasMaxLength(4);
    }
}
public class DetallesCuentumConfiguration : IEntityTypeConfiguration<DetallesCuentum>
{
    public void Configure(EntityTypeBuilder<DetallesCuentum> builder)
    {
        builder.Property(detallesCuentum => detallesCuentum.DetallesC)
        .HasPrecision(11);
        builder.Property(detallesCuentum => detallesCuentum.Saldo)
        .HasPrecision(11);
        builder.Property(detallesCuentum => detallesCuentum.PrestamoA)
        .HasMaxLength(4);
    }
}
public class DetallesEmpleadoConfiguration : IEntityTypeConfiguration<DetallesEmpleado>
{
    public void Configure(EntityTypeBuilder<DetallesEmpleado> builder)
    {
        builder.Property(detallesEmpleado => detallesEmpleado.DetallesE)
        .HasPrecision(11);
        builder.Property(detallesEmpleado => detallesEmpleado.PrestamosAprobados)
        .HasPrecision(11);

    }
}
public class DetallesGerenteConfiguration : IEntityTypeConfiguration<DetallesGerente>
{
    public void Configure(EntityTypeBuilder<DetallesGerente> builder)
    {
        builder.Property(detallesGerente => detallesGerente.DetallesG)
        .HasPrecision(11);
        builder.Property(detallesGerente => detallesGerente.DiasVacaciones)
        .HasPrecision(11);

    }
}
public class DetallesHistorialConfiguration : IEntityTypeConfiguration<DetallesHistorial>
{
    public void Configure(EntityTypeBuilder<DetallesHistorial> builder)
    {
        builder.Property(detallesHistorial => detallesHistorial.DetallesH)
        .HasPrecision(11);
        builder.Property(detallesHistorial => detallesHistorial.NPagosRealizados)
        .HasPrecision(11);
        builder.Property(detallesHistorial => detallesHistorial.NPagosPendientes)
        .HasPrecision(11);
        builder.Property(detallesHistorial => detallesHistorial.Estado)
        .HasMaxLength(10);

    }
}
public class DetallesPrestamoConfiguration : IEntityTypeConfiguration<DetallesPrestamo>
{
    public void Configure(EntityTypeBuilder<DetallesPrestamo> builder)
    {
        builder.Property(detallesPrestamo => detallesPrestamo.DetallesP)
        .HasPrecision(11);
        builder.Property(detallesPrestamo => detallesPrestamo.FechaSolicitud)
        .HasPrecision(11);
        builder.Property(detallesPrestamo => detallesPrestamo.FechaAprobacion)
        .HasPrecision(11);
        builder.Property(detallesPrestamo => detallesPrestamo.FechaLiquidacion)
        .HasPrecision(11);
        builder.Property(detallesPrestamo => detallesPrestamo.Periodo)
        .HasPrecision(11);

    }
}
public class DetallesUsuarioConfiguration : IEntityTypeConfiguration<DetallesUsuario>
{
    public void Configure(EntityTypeBuilder<DetallesUsuario> builder)
    {
        builder.Property(detallesUsuario => detallesUsuario.DetallesU)
        .HasPrecision(11);
        builder.Property(detallesUsuario => detallesUsuario.Curp)
        .HasMaxLength(18);
        builder.Property(detallesUsuario => detallesUsuario.Solicitud)
        .HasMaxLength(10);

    }
}
public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.Property(empleado => empleado.IdEmpleado)
        .HasPrecision(11);

    }
}
public class GerenteConfiguration : IEntityTypeConfiguration<Gerente>
{
    public void Configure(EntityTypeBuilder<Gerente> builder)
    {
        builder.Property(gerente => gerente.IdGerente)
        .HasPrecision(11);

    }
}
public class HistorialConfiguration : IEntityTypeConfiguration<Historial>
{
    public void Configure(EntityTypeBuilder<Historial> builder)
    {
        builder.Property(historial => historial.IdHistorial)
        .HasPrecision(11);
        builder.Property(historial => historial.Cantidad)
        .HasPrecision(11);

    }
}
public class NominaConfiguration : IEntityTypeConfiguration<Nomina>
{
    public void Configure(EntityTypeBuilder<Nomina> builder)
    {
        builder.Property(nomina => nomina.Nomina1)
        .HasPrecision(11);

    }
}
public class PrestamoConfiguration : IEntityTypeConfiguration<Prestamo>
{
    public void Configure(EntityTypeBuilder<Prestamo> builder)
    {
        builder.Property(prestamo => prestamo.Folio)
        .HasPrecision(11);
        builder.Property(prestamo => prestamo.Monto)
        .HasPrecision(18,2);
        builder.Property(prestamo => prestamo.PagoMes)
        .HasPrecision(18,2);
        builder.Property(prestamo => prestamo.FechaUpago)
        .HasPrecision(11);
        builder.Property(prestamo => prestamo.Status)
        .HasMaxLength(15);


    }
}
public class RifaConfiguration : IEntityTypeConfiguration<Rifa>
{
    public void Configure(EntityTypeBuilder<Rifa> builder)
    {
        builder.Property(rifa => rifa.NBoleto)
        .HasPrecision(11);
        builder.Property(rifa => rifa.FechaBoleto)
        .HasPrecision(11);

    }
}
public class SolicitudConfiguration : IEntityTypeConfiguration<Solicitud>
{
    public void Configure(EntityTypeBuilder<Solicitud> builder)
    {
        builder.Property(solicitud => solicitud.IdSolicitud)
        .HasPrecision(11);
        builder.Property(solicitud => solicitud.StatusSolicitud)
        .HasMaxLength(10);

    }
}
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.Property(usuario => usuario.IdUsuario)
        .HasMaxLength(10);

    }
}
